using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakCage : MonoBehaviour
{
    public float x_speed;
    public float y_speed;

    public int cage_health = 5;

    public Rigidbody2D rb;

    void Start()
    {
        
    }

    void Update()
    {
        x_speed = rb.velocity.x;
        y_speed = rb.velocity.y;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Wall")
        {
            if (Mathf.Abs(x_speed) + Mathf.Abs(y_speed) > 15)
            {
                cage_health -= 1; // make it so damage scales with height later
            }
        }
    }
}
