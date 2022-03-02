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

    public Animator anim;

    [HideInInspector]
    public bool isFacingLeft;
    [HideInInspector]
    public bool isGrounded;
    [HideInInspector]
    public bool isJumping;
    [HideInInspector]
    public bool isShooting;
    [HideInInspector]
    public bool shootDelay;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) //Jump
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
            isJumping = true;
        }
        if (Input.GetKeyDown(KeyCode.S)) //Fast Fall
        {
            rb.AddForce(Vector2.down * jumpAmount, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.A)) //Left
        {
            rb.AddForce(Vector2.left * runningSpeed, ForceMode2D.Impulse);
            
        }
        if (Input.GetKeyDown(KeyCode.D)) //Right
        {
            rb.AddForce(Vector2.right * runningSpeed, ForceMode2D.Impulse);
        }
        if (Input.GetButtonDown("Fire"))
        {
            
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



