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
    private bool canWalk = true;
    private bool canNormal;
    private bool canSP;
    private bool canDash;
    private bool canEX;
    private bool canSuper;


    #region LP
    [Header("LP variables")]
    public GameObject lpBox;
    public float lpHitstun;
    public float lpBlockstun;
    public float lpHitpush;
    public float lpBlockpush;
    #endregion LP

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

    public void Attack(InputAction.CallbackContext context)
    {
        if (context.performed) //&& can move == true
        {
            if (IsGrounded() == true)
            {
                LPAnim();
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
