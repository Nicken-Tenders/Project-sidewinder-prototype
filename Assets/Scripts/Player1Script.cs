using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;


public class Player1Script : MonoBehaviour
{
    //New Sidewinder script

    //Details about the world
    public InputActionAsset controls;
    public LayerMask groundMask;
    public LayerMask hitboxLayers;
    private Collider2D priorityHitBox;
    public DummyController dc;
    //public CanMove cmScript;

    //Details about the player
    public Animator animator;
    public Collider2D col;
    //public Rigidbody2D rb;
    [SerializeField] private float walkSpeed;
    [SerializeField] private float jumpHeight;
    public bool moveBool;
    public bool missionMove;
    ///work out a priority system
    ///or maybe work it out in the animator
    //private bool canWalk = true;
    //private bool canNormal;
    //private bool canSP;
    //private bool canDash;
    //private bool canEX;
    //private bool canSuper;

    #region LP
    [Header("LP variables")]
    public GameObject lpBox;
    public float lpHitstun;
    public float lpBlockstun;
    public float lpHitpush;
    public float lpBlockpush;
    #endregion LP

    #region HK
    [Header("HK variables")]
    public GameObject hkBox;
    public float hkHitstun;
    public float hkBlockstun;
    public float hkHitpush;
    public float hkBlockpush;
    #endregion HK

    //Outgoing variables
    private Vector2 moveVar;
    [HideInInspector] public float hitstun;
    [HideInInspector] public float blockstun;
    [HideInInspector] public float knockdown;

    void Update()
    {
        if (missionMove == true)
        {
            if (moveBool == true)
                transform.Translate(Vector2.right * moveVar.x * walkSpeed * Time.deltaTime);
        }

        if (CommandSequences.SequenceIsCompleted("Taunt"))
            Taunt();
    }

    public void Walk(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            /*&& IsGrounded() == true*/
            moveVar = context.ReadValue<Vector2>();
        }

        //if (context.interaction is MultiTapInteraction)
        //    Dash();
    }

    public void LP(InputAction.CallbackContext context)
    {
        if (context.performed) //&& can move == true
        {
            if (IsGrounded() == true)
            {
                LPAnim();
            }
        }
    }
    public void HK(InputAction.CallbackContext context)
    {
        if (context.performed) //&& can move == true
        {
            if (IsGrounded() == true)
            {
                HKAnim();
            }
        }
    }

    #region attacks
    #region LP
    public void LPAnim()
    {
        StartCoroutine(QueueTime("LP", 3));
    }
    public void LPHitOn()
    {
        Collider2D[] hitboxes = Physics2D.OverlapBoxAll(lpBox.transform.position, lpBox.transform.localScale, hitboxLayers);

        int layerHit = -1;
        priorityHitBox = null;

        foreach (Collider2D box in hitboxes)
        {
            if (box.gameObject.layer > layerHit)
            {
                layerHit = box.gameObject.layer;
                priorityHitBox = box;
            }
            if (priorityHitBox.gameObject.layer == LayerMask.NameToLayer("P2 Hurt Box"))
            {
                LPOnHit();
            }
            else if (priorityHitBox.gameObject.layer == LayerMask.NameToLayer("P2 Block Box"))
            {
                LPOnBlock();
            }
            else
            {
                //Debug.Log("null");
            }

            if (box.gameObject.tag == "Target")
            {
                box.gameObject.SetActive(false);
            }
        }
    }
    public void LPOnHit()
    {
        hitstun = lpHitstun;
        dc.Hitstun(hitstun);
    }
    public void LPOnBlock()
    {
        blockstun = lpBlockstun;
        dc.Hitstun(blockstun);
    }
    public void LPHitOff()
    {
        //LPHit.enabled = false;
    }
    #endregion LP
    #region HK
    public void HKAnim()
    {
        StartCoroutine(QueueTime("HK", 3));
    }
    public void HKHitOn()
    {
        Collider2D[] hitboxes = Physics2D.OverlapBoxAll(hkBox.transform.position, hkBox.transform.localScale, hitboxLayers);

        int layerHit = -1;
        priorityHitBox = null;

        foreach (Collider2D box in hitboxes)
        {
            if (box.gameObject.layer > layerHit)
            {
                layerHit = box.gameObject.layer;
                priorityHitBox = box;
            }
            if (priorityHitBox.gameObject.layer == LayerMask.NameToLayer("P2 Hurt Box"))
            {
                HKOnHit();
            }
            else if (priorityHitBox.gameObject.layer == LayerMask.NameToLayer("P2 Block Box"))
            {
                HKOnBlock();
            }
            else
            {
                //Debug.Log("null");
            }

            if (box.gameObject.tag == "Target")
            {
                box.gameObject.SetActive(false);
            }
        }
    }
    public void HKOnHit()
    {
        hitstun = hkHitstun;
        dc.Hitstun(hitstun);
    }
    public void HKOnBlock()
    {
        blockstun = hkBlockstun;
        dc.Hitstun(blockstun);
    }
    public void HKHitOff()
    {
        //HKHit.enabled = false;
    }
    #endregion HK

    void Taunt()
    {
        animator.SetTrigger("Taunt");
    }
    #endregion attacks

    //public void Dash()
    //{
    //    //Debug.Log("Dashed");
    //    animator.SetTrigger("Dash");
    //}

    private bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.BoxCast
            (col.bounds.center, col.bounds.size, 0, Vector2.down, 0.05f, groundMask);
        return hit.transform != null;
    }
    public void CanMove()
    {
        moveBool = true;
    }

    public void NoMove()
    {
        moveBool = false;
    }

    IEnumerator QueueTime(string move, int frames)
    {
        animator.SetTrigger(move);
        yield return frames;
        animator.ResetTrigger(move);
    }
}
