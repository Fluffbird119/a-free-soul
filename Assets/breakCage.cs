using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakCage : MonoBehaviour
{
    public float x_speed;
    public float y_speed;

    public int cage_health = 5;

    public Rigidbody2D rb;

    private GameObject holdervar;

    public GameObject[] cage_pieces;

    public int explosion_force = 5;


    void Start()
    {
        
    }

    void Update()
    {
        x_speed = rb.velocity.x;
        y_speed = rb.velocity.y;

        if (cage_health <= 0)
        {
            for (int i = 0; i < 10; i++)
            {
                holdervar = Instantiate(cage_pieces[i], transform.position, transform.rotation);
                holdervar.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(10, 10),ForceMode2D.Impulse);
            }

            Destroy(gameObject);
        }
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
