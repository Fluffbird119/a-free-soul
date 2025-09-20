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

    public int explosion_force = 5;

    public int y_damage_scaler;

    int x_force;
    int y_force;

    [SerializeField] int force_multiplier = 5;

    public GameObject[] cage_pieces;

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
                x_force = Random.Range(-5, 5) * force_multiplier;
                y_force = Random.Range(-5, 5) * force_multiplier;

                holdervar = Instantiate(cage_pieces[i], new Vector3(transform.position.x + y_force/10, transform.position.y + x_force/10), transform.rotation);
                holdervar.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(x_force, y_force),ForceMode2D.Impulse);
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
                if (x_speed < 2)
                {
                    y_damage_scaler = 10; // higher = less damage
                }
                else if (x_speed >= 2)
                {
                    y_damage_scaler = 15;
                }
                cage_health -= 1 + (int)(Mathf.Abs(x_speed) / 15 + Mathf.Abs(y_speed) / y_damage_scaler); // make it so damage scales with height later
            }
        }
    }
}
