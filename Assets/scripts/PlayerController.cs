using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;
    public float jumpAmount;

    public KeyCode left;
    public KeyCode right;
    public KeyCode jump;
    public KeyCode attack;

    public Transform groundCheckPoint;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    public GameObject bullet;
    public Transform bulletHB;

    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, whatIsGround);

        if (Input.GetKeyDown(jump) && isGrounded) //Jump
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(left)) //Left
        {
            rb.AddForce(Vector2.left * moveSpeed, ForceMode2D.Impulse);

        }
        if (Input.GetKeyDown(attack))
        {
            //OnCollisionEnter();
        }
        if (Input.GetKeyDown(right)) //Right
        {
            rb.AddForce(Vector2.right * moveSpeed, ForceMode2D.Impulse);
        }
    }
    /*
    void OnCollisionEnter(Collider target)
    {
        if (target.gameObject.tag.Equals("Player1") == true)
        {
            //FindObjectOfType<GameManager>().HurtP1();
        }
        if (target.gameObject.tag.Equals("Player2") == true)
        {
            //FindObjectOfType<GameManager>().HurtP2();
        }

    }
    */

}
