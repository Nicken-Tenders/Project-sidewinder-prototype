using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Walking : MonoBehaviour
{
    public Basecontroller bc;

    [SerializeField] private float walkSpeed;

    void Update()
    {
        if (bc.IsGrounded() == true)
        {
            transform.parent.Translate(Vector2.right * bc.moveVar.x * walkSpeed * Time.deltaTime);
            bc.animator.SetInteger("Walk", (int)bc.moveVar.x);
        }
    }

    public void Walk(InputAction.CallbackContext context)
    {
        if (context.performed)
            bc.moveVar = context.ReadValue<Vector2>();
    }
}
