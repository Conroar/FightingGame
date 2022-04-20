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
    public KeyCode attack;

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
        if (Input.GetKeyDown(KeyCode.UpArrow)) //Jump
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
            isJumping = true;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) //Fast Fall
        {
            rb.AddForce(Vector2.down * jumpAmount, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) //Left
        {
            rb.AddForce(Vector2.left * runningSpeed, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) //Right
        {
            rb.AddForce(Vector2.right * runningSpeed, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(attack))
        {
            if (gameObject.tag.Equals("Player2") == true)
            {
                FindObjectOfType<GameController>().HurtP2();
            }
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



