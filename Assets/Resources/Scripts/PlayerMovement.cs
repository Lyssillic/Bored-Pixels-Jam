using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;
    float horizontal;
    Rigidbody2D rb2d;
    Sprite[] playerSprites;

    void Start()
    {
        playerSprites = Resources.LoadAll<Sprite>("Sprites/Isi");
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get the player horizontal movement
        horizontal = Input.GetAxisRaw("Horizontal");

        // Set player sprite direction
        // Left 
        if (horizontal < 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = playerSprites[1];
        }
        // Right
        else if (horizontal > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = playerSprites[0];
        }
        
        // Player horizontal movement
        Vector2 movement = new Vector2(horizontal, 0f);
        rb2d.velocity = movement * speed;
    }
}
