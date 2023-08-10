using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class P_Walking : MonoBehaviour
{
    public P_Basecontroller pbc;

    [SerializeField] private float walkSpeed = 4;

    void Update()
    {
        if (pbc.IsGrounded() == true)
        {
            transform.parent.Translate(Vector2.right * pbc.moveVar.x * walkSpeed * Time.deltaTime);
            pbc.animator.SetInteger("Walk", (int)pbc.moveVar.x);
        }
    }

    public void Walk(InputAction.CallbackContext context)
    {
        if (context.performed)
            pbc.moveVar = context.ReadValue<Vector2>();
    }
}
