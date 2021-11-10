using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    public GameObject Player;
    public Animator animator;
    public float walkSpeed = 4;
    public BoxCollider2D LPHit;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetButton("Down"))
        {
            Debug.Log("Down!");
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
            Debug.Log("HP!");
        }
        if (Input.GetButtonDown("LK"))
        {
            Debug.Log("LK!");
        }
        if (Input.GetButtonDown("HK"))
        {
            Debug.Log("HK!");
        }
        if (Input.GetButton("MLeft") && !Input.GetButton("MRight"))
        {
            Player.transform.Translate(Vector2.left * walkSpeed * Time.deltaTime);
        }
        if (Input.GetButton("MRight") && !Input.GetButton("MLeft"))
        {
            Player.transform.Translate(Vector2.right * walkSpeed * Time.deltaTime);
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

    void LPAnim()
    {
        animator.SetTrigger("LP");
        //put out the proper boxes
    }

    public void LPHitOn()
    {
        LPHit.enabled = true;
    }
    public void LPHitOff()
    {
        LPHit.enabled = false;
    }
}
