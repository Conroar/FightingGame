using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpAmount = 60;
    public float gravityScale = 10;
    public float fallingGravityScale = 20;
    public float runningSpeed = 60;

    [HideInInspector]
    public bool isFacingLeft;
    [HideInInspector]
    public bool isGrounded;
    [HideInInspector]
    public bool isJumping;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
            isJumping = true;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(Vector2.down * jumpAmount, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(Vector2.left * runningSpeed, ForceMode2D.Impulse);
            
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(Vector2.right * runningSpeed, ForceMode2D.Impulse);
        }



        if (rb.velocity.y >= 0)
        {
            rb.gravityScale = gravityScale;
        }
        else if (rb.velocity.y < 0)
        {
            rb.gravityScale = fallingGravityScale;
        }
        rb.angularDrag = 20F;
    }
}



