using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorfulMidas : MonoBehaviour
{
    private Rigidbody2D rb;
    private Color[] colors = {Color.red, Color.blue, Color.green, Color.yellow, Color.cyan, Color.magenta};
    public GameObject cage;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject otherObject = collision.gameObject;
        SpriteRenderer sprite = otherObject.GetComponent<SpriteRenderer>();
        if (sprite != null && (cage == null || otherObject.name != cage.name))
        {
            System.Random random = new System.Random();
            sprite.color = colors[random.Next(colors.Length)];
        }
    }
}
