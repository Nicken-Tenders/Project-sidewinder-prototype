using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    public GameObject PlayerMiddle;
    public Animator animator;
    public float walkSpeed = 4;
    public bool isCrouching;
    public bool isGrounded = true;
    public Rigidbody2D rb;
    public int yump;

    public BoxCollider2D LPHit;
    public BoxCollider2D HPHit;
    public BoxCollider2D LKHit;
    public BoxCollider2D HKHit;
    public BoxCollider2D CLPHit;
    public BoxCollider2D CHPHit;
    public BoxCollider2D CLKHit;
    public BoxCollider2D CHKHit;

    public bool moveBool = true;
    public bool actBool = true;

    void Update()
    {
        if (Input.GetButtonDown("Down"))
        {
            CrouchAnim();
        }
        if (Input.GetButtonDown("Up"))
        {
            Debug.Log("Up!");
        }
        if (Input.GetButtonDown("Accept"))
        {
            Debug.Log("Accept!");
        }
        if (Input.GetButtonDown("Cancel"))
        {
            Debug.Log("Cancel!");
        }

        if (Input.GetButtonDown("LP"))
        {
            if (Input.GetButton("Down"))
            {
                CLPAnim();
            }
            else
            {
                LPAnim();
            }
        }
        if (Input.GetButtonDown("HP"))
        {
            if (Input.GetButton("Down"))
            {
                CHPAnim();
            }
            else
            {
                HPAnim();
            }
        }
        if (Input.GetButtonDown("LK"))
        {
            if (Input.GetButton("Down"))
            {
                CLKAnim();
            }
            else
            {
                LKAnim();
            }
        }
        if (Input.GetButtonDown("HK"))
        {
            if (Input.GetButton("Down"))
            {
                CHKAnim();
            }
            else
            {
                HKAnim();
            }
        }
        if (Input.GetButton("MLeft") && !Input.GetButton("MRight"))
        {
            if (moveBool == true)
            {
                PlayerMiddle.transform.Translate(Vector2.left * walkSpeed * Time.deltaTime);
            }
        }
        if (Input.GetButton("MRight") && !Input.GetButton("MLeft"))
        {
            if (moveBool == true)
            {
                PlayerMiddle.transform.Translate(Vector2.right * walkSpeed * Time.deltaTime);
            }
        }
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            Jump();
        }
        if (Input.GetButtonDown("Start"))
        {
            Debug.Log("Start!");
        }
        if (Input.GetButtonDown("Select"))
        {
            Debug.Log("Select!");
        }
    }

    public void CanMove()
    {
        moveBool = true;
    }

    #region LP
    void LPAnim()
    {
        animator.SetTrigger("LP");
        moveBool = false;
    }

    public void LPHitOn()
    {
        LPHit.enabled = true;
    }
    public void LPHitOff()
    {
        LPHit.enabled = false;
    }
    #endregion

    #region HP
    void HPAnim()
    {
        animator.SetTrigger("HP");
        moveBool = false;
    }

    public void HPHitOn()
    {
        HPHit.enabled = true;
    }
    public void HPHitOff()
    {
        HPHit.enabled = false;
    }
    #endregion

    #region LK
    void LKAnim()
    {
        animator.SetTrigger("LK");
        moveBool = false;
    }

    public void LKHitOn()
    {
        LKHit.enabled = true;
    }
    public void LKHitOff()
    {
        LKHit.enabled = false;
    }
    #endregion

    #region HK
    void HKAnim()
    {
        animator.SetTrigger("HK");
        moveBool = false;
    }

    public void HKHitOn()
    {
        HKHit.enabled = true;
    }
    public void HKHitOff()
    {
        HKHit.enabled = false;
    }
    #endregion

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
        moveBool = false;
    }

    public void CLPHitOn()
    {
        CLPHit.enabled = true;
    }
    public void CLPHitOff()
    {
        CLPHit.enabled = false;
    }
    #endregion

    #region CHP
    void CHPAnim()
    {
        animator.SetTrigger("CHP");
        moveBool = false;
    }

    public void CHPHitOn()
    {
        CHPHit.enabled = true;
    }
    public void CHPHitOff()
    {
        CHPHit.enabled = false;
    }
    #endregion

    #region CLK
    void CLKAnim()
    {
        animator.SetTrigger("CLK");
        moveBool = false;
    }

    public void CLKHitOn()
    {
        CLKHit.enabled = true;
    }
    public void CLKHitOff()
    {
        CLKHit.enabled = false;
    }
    #endregion

    #region CHK
    void CHKAnim()
    {
        animator.SetTrigger("CHK");
        moveBool = false;
    }

    public void CHKHitOn()
    {
        CHKHit.enabled = true;
    }
    public void CHKHitOff()
    {
        CHKHit.enabled = false;
    }
    #endregion

    #region Jump
    void Jump()
    {
        animator.SetTrigger("Jump");
        rb.AddForce(transform.up * yump);
        moveBool = false;
    }
    #endregion

    #region JumpForward
    //void JumpForward()
    //{
        //animator.SetTrigger("JumpForward");
        //rb.Addforce(walkSpeed, yump);
        //moveBool = false;
    //}
    #endregion

    #region JumpBackward
    /*void JumpBackward()
    {
        animator.SetTrigger("JumpBackward");
        rb.Addforce(-walkSpeed, yump);
        moveBool = false;
    }*/
    #endregion
}
