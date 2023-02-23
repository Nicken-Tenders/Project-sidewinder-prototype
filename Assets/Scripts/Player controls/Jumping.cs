using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jumping : MonoBehaviour
{
    public Basecontroller bc;

    [SerializeField] private float jumpForce;

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (bc.IsGrounded() == true)
            {
                bc.rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }
        }
    }
}
