using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class P_Jumping : MonoBehaviour
{
    public P_Basecontroller pbc;

    [SerializeField] private float jumpForce = 5;

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (pbc.IsGrounded() == true)
            {
                pbc.rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }
        }
    }
}
