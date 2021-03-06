using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class Player1Controller : MonoBehaviour
{
    //Old Sidewinder script

    //Details about the world
    public PlayerInput controls;
    public InputControl inputControl;
    public InputAction action;
    public InputActionAsset controlsAlt;
    public DummyController ds;

    //Details about the player
    public Animator animator;
    public Rigidbody2D rb;
    public BoxCollider2D spriteCol;
    public CanMove cm;

    //Outgoing variables
    public float hitstun;
    public float blockstun;
    public float knockdown;

    //Incoming variables


    public GameObject playerMiddle;
    public LayerMask groundMask;
    public float walkSpeed;
    public bool isCrouching;
    public float jumpInt;


    public LayerMask hitboxLayers;
    private Collider2D priorityHitBox;


    public Transform lpBox;
    public Vector2 lpRange;
    public float lpHitstun;
    public float lpBlockstun;

    public bool moveBool = true;
    public bool actBool = true;
    public int priorityLvl = -1;

    void Awake()
    {
        //action = new InputAction(type: InputActionType.Button, binding: "<Keyboard>/j");

        action.performed +=
            ctx => LPAnim(ctx);
            //{
            //    var button = (ButtonControl)ctx.control;
            //    if (button.wasPressedThisFrame)
            //        Debug.Log($"Button {ctx.control} was pressed");
            //
            //};

        action.Enable();

    }

    private void Action_started(InputAction.CallbackContext obj)
    {
        throw new System.NotImplementedException();
    }

    private void OnEnable()
    {
        action.Enable();
    }
    private void OnDisable()
    {
        action.Disable();
    }

    void Update()
    {
        
        #region Menu controls
        //if (Input.GetButtonDown("Down"))
        //{

        //}
        //if (Input.GetButtonDown("Up"))
        //{

        //}
        //if (Input.GetButtonDown("Accept"))
        //{

        //}
        //if (Input.GetButtonDown("Cancel"))
        //{

        //}
        #endregion

        //if (Input.GetButtonDown("LP"))
        //{
        //    if (IsGrounded() == true)
        //    {
        //        if (Input.GetButton("Down"))
        //        {
        //            //CLPAnim();
        //        }
        //        else
        //        {
        //            LPAnim();
        //        }
        //    }
        //}
        //if (Input.GetButtonDown("HP"))
        //{
        //    if (IsGrounded() == true)
        //    {
        //        if (Input.GetButton("Down"))
        //        {
        //            //CHPAnim();
        //        }
        //        else
        //        {
        //            HPAnim();
        //        }
        //    }
        //}
        //if (Input.GetButtonDown("LK"))
        //{
        //    if (IsGrounded() == true)
        //    {
        //        if (Input.GetButton("Down"))
        //        {
        //            //CLKAnim();
        //        }
        //        else
        //        {
        //            LKAnim();
        //        }
        //    }
        //}
        //if (Input.GetButtonDown("HK"))
        //{
        //    if (IsGrounded() == true)
        //    {
        //        if (Input.GetButton("Down"))
        //        {
        //            //CHKAnim();
        //        }
        //        else
        //        {
        //            HKAnim();
        //        }
        //    }
        //}
        //if (IsGrounded() == true && moveBool == true)
        //{
        //    if (Input.GetButton("MLeft") && !Input.GetButton("MRight"))
        //    {
        //        WalkBack();
        //    }
        //    if (Input.GetButton("MRight") && !Input.GetButton("MLeft"))
        //    {
        //        WalkForward();
        //    }
        //    if (Input.GetButtonDown("Jump"))
        //    {
        //        Jump();
        //    }
        //}
        //if (Input.GetButtonDown("Start"))
        //{
        //    Debug.Log("Start!");
        //}
        //if (Input.GetButtonDown("Select"))
        //{
        //    Debug.Log("Select!");
        //}
        //if (CommandSequences.SequenceIsCompleted("Taunt"))
        //{
        //    Taunt();
        //}


    }

    #region Attacks
    #region LP
    public void LPAnim(InputAction.CallbackContext ctx)
    {
        Debug.Log("LPAnim Started");
        if (ctx.performed)
        {
            Debug.Log("LP registered");
            animator.SetTrigger("LP");
        }
        else
            Debug.Log(ctx.started);
    }
    public void LPHitOn()
    {
        Collider2D[] hitboxes = Physics2D.OverlapBoxAll(lpBox.position, lpRange, 0, hitboxLayers);

        int layerHit = -1;
        priorityHitBox = null;

        foreach (Collider2D box in hitboxes)
        {
            if(box.gameObject.layer > layerHit)
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
                Debug.Log("null");
            }
        }
    }

    public void LPOnHit()
    {
        hitstun = lpHitstun;
        ds.Hitstun(hitstun);
    }
    public void LPOnBlock()
    {
        blockstun = lpBlockstun;
        ds.Hitstun(blockstun);
    }

    public void LPHitOff()
    {
        //LPHit.enabled = false;
    }
    private void OnDrawGizmosSelected()
    {
        if (lpBox == null)
        {
            Debug.LogWarning("Can't find LP Hitbox");
        }

        Gizmos.DrawWireCube(lpBox.position, lpRange);
    }
    #endregion LP

    #region HP
    void HPAnim()
    {
        animator.SetTrigger("HP");
    }

    public void HPHitOn()
    {
        
    }
    public void HPHitOff()
    {
        
    }
    #endregion HP

    #region LK
    void LKAnim()
    {
        animator.SetTrigger("LK");
    }

    public void LKHitOn()
    {
        
    }
    public void LKHitOff()
    {
        
    }
    #endregion LK

    #region HK
    void HKAnim()
    {
        animator.SetTrigger("HK");
    }

    public void HKHitOn()
    {
        
    }
    public void HKHitOff()
    {
        
    }
    #endregion HK

    #region Crouch
    void CrouchAnim()
    {
        animator.SetTrigger("Crouch");
    }
    #endregion

    #region CLP
    void CLPAnim()
    {
        animator.SetTrigger("CLP");
    }

    public void CLPHitOn()
    {
        
    }
    public void CLPHitOff()
    {
        
    }
    #endregion CLP

    #region CHP
    void CHPAnim()
    {
        animator.SetTrigger("CHP");
    }

    public void CHPHitOn()
    {
        
    }
    public void CHPHitOff()
    {
        
    }
    #endregion CHP

    #region CLK
    void CLKAnim()
    {
        animator.SetTrigger("CLK");
    }

    public void CLKHitOn()
    {
        
    }
    public void CLKHitOff()
    {
        
    }
    #endregion CLK

    #region CHK
    void CHKAnim()
    {
        animator.SetTrigger("CHK");
    }

    public void CHKHitOn()
    {
        
    }
    public void CHKHitOff()
    {
        
    }
    #endregion CHK
    #endregion Attacks

    #region Movement
    public void CanMove()
    {
        moveBool = true;
    }

    #region Jump
    void Jump()
    {
            //animator.SetTrigger("Jump");
        if (Input.GetButton("MRight") && !Input.GetButton("MLeft"))
        {
            //rb.velocity = Vector2.zero;
            //rb.AddForce(new Vector2(walkSpeed * 100, jumpInt));
            rb.velocity = new Vector2(rb.velocity.x, jumpInt);
            //rb.AddForce(new Vector2(rb.velocity.x, jumpInt));
            //rb.AddForce(new Vector2(1, jumpInt));
        }
        else if (Input.GetButton("MLeft") && !Input.GetButton("MRight"))
        {
            //rb.AddForce(transform.right * -walkSpeed * 500 + transform.up * jumpInt);
            rb.velocity = new Vector2(rb.velocity.x, jumpInt);
        }
        else
        {
            //rb.AddForce(transform.up * jumpInt);
            rb.velocity = new Vector2(rb.velocity.x, jumpInt);
        }

        //Debug.Log(rb.velocity);
    }
    #endregion Jump

    #region Walks
    void WalkForward()
    {
        rb.velocity = new Vector2(walkSpeed, rb.velocity.y);

        //Debug.Log("2" + rb.velocity);
        if (moveBool == true && IsGrounded() == true)
        {
            //PlayerMiddle.transform.Translate(Vector2.right * walkSpeed * Time.deltaTime);

        }
    }
    void WalkBack()
    {
        rb.velocity = new Vector2(-walkSpeed, rb.velocity.y);

        //Debug.Log("1" + rb.velocity);
        if (moveBool == true && IsGrounded() == true)
        {
            //PlayerMiddle.transform.Translate(Vector2.left * walkSpeed * Time.deltaTime);

        }
    }
    #endregion Walks

    private bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.BoxCast
            (spriteCol.bounds.center, spriteCol.bounds.size, 0, Vector2.down, 0.05f, groundMask);
        return hit.transform != null;
    }
    #endregion Movement

    void Taunt()
    {
        animator.SetTrigger("Taunt");
    }
}
