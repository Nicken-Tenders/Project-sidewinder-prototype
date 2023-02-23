using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Basecontroller : MonoBehaviour
{
    [SerializeField] private LayerMask groundMask;

    // Resources other scripts require to function properly
    public InputActionAsset controls;
    public Animator animator;
    public Collider2D col;
    public Rigidbody2D rb;

    // Character status elements
    public bool grounded = true;
    public Vector2 moveVar;

    public bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.BoxCast
            (col.bounds.center, col.bounds.size, 0, Vector2.down, 0.05f, groundMask);
        return hit.transform != null;
    }
}
