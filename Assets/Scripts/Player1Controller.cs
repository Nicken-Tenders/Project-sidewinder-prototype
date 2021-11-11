using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    public GameObject PlayerMiddle;
    public Animator animator;
    public float walkSpeed = 4;
    public bool isCrouching;

    public BoxCollider2D LPHit;
    public BoxCollider2D HPHit;
    public BoxCollider2D LKHit;
    public BoxCollider2D HKHit;
    public BoxCollider2D CLPHit;
    public BoxCollider2D CHPHit;
    public BoxCollider2D CLKHit;
    public BoxCollider2D CHKHit;

    public bool ActBool = true;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetButton("Down"))
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
            LPAnim();
        }
        if (Input.GetButtonDown("HP"))
        {
            HPAnim();
        }
        if (Input.GetButtonDown("LK"))
        {
            LKAnim();
        }
        if (Input.GetButtonDown("HK"))
        {
            HKAnim();
        }
        if (Input.GetButton("MLeft") && !Input.GetButton("MRight"))
        {
            if (ActBool == true)
            {
                PlayerMiddle.transform.Translate(Vector2.left * walkSpeed * Time.deltaTime);
            }
        }
        if (Input.GetButton("MRight") && !Input.GetButton("MLeft"))
        {
            if (ActBool == true)
            {
                PlayerMiddle.transform.Translate(Vector2.right * walkSpeed * Time.deltaTime);
            }
        }
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Jump!");
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

    public void CanAct()
    {
        ActBool = true;
    }

    #region LP
    void LPAnim()
    {
        animator.SetTrigger("LP");
        ActBool = false;
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
        ActBool = false;
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
        ActBool = false;
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
        ActBool = false;
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
        isCrouching = true;
    }
    #endregion

    #region CLP
    void CLPAnim()
    {
        animator.SetTrigger("CLP");
        ActBool = false;
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
        ActBool = false;
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
        ActBool = false;
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
        ActBool = false;
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
}
