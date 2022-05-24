using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] Rigidbody2D rb;
    [SerializeField] LayerMask ground;

    [Header("Stats")]    
    [SerializeField] float moveSpeed;
    [SerializeField] float cutJumpForce;
    [SerializeField] float fallForce;
    [SerializeField] float gravityScale;

    Vector2 moveDir;
    bool isGrounded;

    void Start()
    {
        
    }

    void Update()
    {
        GetInput();
        MovePlayer();
    }

    // Gets character input...
    void GetInput() {
        moveDir = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
        );
    }

    // Movement horizontal...
    void MovePlayer() {
        rb.velocity = new Vector2(
            moveDir.x * moveSpeed,
            rb.velocity.y
        );
    }

    void Jump() {

    }

    void CutJump() {

    }

}
