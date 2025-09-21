using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakCageSquare : MonoBehaviour
{
    public Rigidbody2D rb;

    bool cageBroken = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (cageBroken == true)
        {
            Debug.Log("cage has broken");
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
