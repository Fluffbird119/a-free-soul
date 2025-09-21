using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakCageSquare : MonoBehaviour
{
    public Rigidbody2D rb;

    bool cageBroken = false;

    int x_force;
    int y_force;

    public int force_multiplier = 5;

    public GameObject[] cage_pieces;

    private GameObject tempObj;

    audioScript audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<audioScript>();
    }

    void Update()
    {
        if (cageBroken == true)
        {
            for (int i = 0; i < cage_pieces.Length; i++)
            {
                x_force = Random.Range(-5, 5) * force_multiplier;
                y_force = Random.Range(-5, 5) * force_multiplier;

                tempObj = Instantiate(cage_pieces[i], new Vector3(transform.position.x + y_force / 10, transform.position.y + x_force / 10), transform.rotation);
                tempObj.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(x_force, y_force), ForceMode2D.Impulse);
            }
            audioManager.PlaySFX(audioManager.cageBreak);
            audioManager.PlaySFX(audioManager.winNoise);

            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "breakCage")
        {
            cageBroken = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "breakCage")
        {
            cageBroken = true;
        }
    }
}
