using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed = 1;
    private float jumpForce = 5;

    [SerializeField] private bool isGrounded;

    [SerializeField] private Vector2 moveDir;

    public GameObject cage;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        moveDir.x = Input.GetAxisRaw("Horizontal");
        //moveDir.y = rb.velocity.y;

        // old movement code that touched velocity too much
        /*
        if (isGrounded)
        { 
            if (Input.GetKey(KeyCode.A)) {
                rb.velocity = new Vector2(-speed, rb.velocity.y);
            }
            else if (Input.GetKey(KeyCode.D)) {
                rb.velocity = new Vector2(speed, rb.velocity.y);
            }
            else {
                rb.velocity = new Vector2(0, rb.velocity.y);
            }

            if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space)))
            {
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }
        }
        */
        
        if (isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.W) && cage != null || Input.GetKeyDown(KeyCode.Space) && cage != null)
            {
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }
        }   
    }
    
    private void FixedUpdate()
    {
        if (isGrounded && cage != null)
        {
            rb.AddForce(moveDir * speed, ForceMode2D.Impulse);
        }
        else if (!isGrounded && cage != null)
        {
            rb.AddForce(new Vector2(moveDir.x * speed * 0.5f, 0), ForceMode2D.Impulse);
        }
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
            jumpForce = 125;
        }
        else if (collision.gameObject.tag == "Cage")
        {
            isGrounded = true;
            jumpForce = 25;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
       if (collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
        else if (collision.gameObject.tag == "Cage")
        {
            isGrounded = true;
            jumpForce = 25;
        }
    }

    // in case unity misses the enters trigger
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
        else if (collision.gameObject.tag == "Cage")
        {
            isGrounded = true;
            jumpForce = 25;
        }
    }
}
