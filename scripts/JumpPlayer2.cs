using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlayer2 : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpAmount;
    public float gravityScale;
    public float fallingGravityScale;
    public float runningSpeed;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.AddForce(Vector2.down * jumpAmount, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector2.left * runningSpeed, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
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



