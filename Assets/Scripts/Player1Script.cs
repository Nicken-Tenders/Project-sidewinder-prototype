using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;
using NaughtyAttributes;


public class Player1Script : MonoBehaviour
{
    //New Sidewinder script

    //Details about the world
    public InputActionAsset controls;
    [SerializeField] private LayerMask groundMask;
    [SerializeField] private LayerMask hitboxLayers;
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
    [Foldout("LP variables")] public GameObject lpBox;
    [Foldout("LP variables")] public float lpHitstun;
    [Foldout("LP variables")] public float lpBlockstun;
    [Foldout("LP variables")] public float lpHitpush;
    [Foldout("LP variables")] public float lpBlockpush;
    #endregion LP
    #region HK
    [Foldout("HK variables")] public GameObject hkBox;
    [Foldout("HK variables")] public float hkHitstun;
    [Foldout("HK variables")] public float hkBlockstun;
    [Foldout("HK variables")] public float hkHitpush;
    [Foldout("HK variables")] public float hkBlockpush;
    #endregion HK
    #region cLP
    [Foldout("2LP variables")] public GameObject clpBox;
    [Foldout("2LP variables")] public float clpHitstun;
    [Foldout("2LP variables")] public float clpBlockstun;
    [Foldout("2LP variables")] public float clpHitpush;
    [Foldout("2LP variables")] public float clpBlockpush;
    #endregion cLP
    #region cHK
    [Foldout("2HK variables")] public GameObject chkBox;
    [Foldout("2HK variables")] public float chkHitstun;
    [Foldout("2HK variables")] public float chkBlockstun;
    [Foldout("2HK variables")] public float chkHitpush;
    [Foldout("2HK variables")] public float chkBlockpush;
    #endregion cHK

    //Outgoing variables
    public Vector2 moveVar;
    [HideInInspector] public float hitstun;
    [HideInInspector] public float blockstun;
    [HideInInspector] public float knockdown;

    void Update()
    {
        if (IsGrounded() == true)
        {
            if (moveVar.y == -1)
            {
                animator.SetBool("isCrouching", true);
            }
            else
            {
                animator.SetBool("isCrouching", false);
                if (missionMove == true)
                {
                    if (moveBool == true)
                        transform.parent.Translate(Vector2.right * moveVar.x * walkSpeed * Time.deltaTime);
                }

                if (CommandSequences.SequenceIsCompleted("Taunt"))
                    Taunt();
            }
        }
    }

    public void Walk(InputAction.CallbackContext context)
    {
        if (context.performed)
            moveVar = context.ReadValue<Vector2>();

        //if (context.interaction is MultiTapInteraction)
        //    Dash();
    }

    
    

    #region attacks
    public void AtkP(InputAction.CallbackContext context)
    {
        if (context.performed) //&& can move == true
        {
            if (IsGrounded() == true)
            {
                if (moveVar.y == -1)
                {
                    CLPAnim();
                }
                LPAnim();
            }
        }
    }
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
    #region 2LP
    public void CLPAnim()
    {
        StartCoroutine(QueueTime("2HP", 3));
    }
    public void CLPHitOn()
    {
        Collider2D[] hitboxes = Physics2D.OverlapBoxAll(clpBox.transform.position, clpBox.transform.localScale, hitboxLayers);

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
                CLPOnHit();
            }
            else if (priorityHitBox.gameObject.layer == LayerMask.NameToLayer("P2 Block Box"))
            {
                CLPOnBlock();
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
    public void CLPOnHit()
    {
        hitstun = clpHitstun;
        dc.Hitstun(hitstun);
    }
    public void CLPOnBlock()
    {
        blockstun = clpBlockstun;
        dc.Hitstun(blockstun);
    }
    public void CLPHitOff()
    {
        //LPHit.enabled = false;
    }
    #endregion 2LP
    public void AtkK(InputAction.CallbackContext context)
    {
        if (context.performed) //&& can move == true
        {
            if (IsGrounded() == true)
            {
                if (moveVar.y == -1)
                {
                    CHKAnim();
                }
                HKAnim();
            }
        }
    }
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
    #region 2HK
    public void CHKAnim()
    {
        StartCoroutine(QueueTime("2HK", 3));
    }
    public void CHKHitOn()
    {
        Collider2D[] hitboxes = Physics2D.OverlapBoxAll(chkBox.transform.position, chkBox.transform.localScale, hitboxLayers);

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
                CHKOnHit();
            }
            else if (priorityHitBox.gameObject.layer == LayerMask.NameToLayer("P2 Block Box"))
            {
                CHKOnBlock();
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
    public void CHKOnHit()
    {
        hitstun = chkHitstun;
        dc.Hitstun(hitstun);
    }
    public void CHKOnBlock()
    {
        blockstun = chkBlockstun;
        dc.Hitstun(blockstun);
    }
    public void CHKHitOff()
    {
        //LPHit.enabled = false;
    }
    #endregion 2HK

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
