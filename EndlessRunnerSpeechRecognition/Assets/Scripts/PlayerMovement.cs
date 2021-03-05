using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 1, jumpForce = 0.8f;

    private Rigidbody2D rb;

    private bool isOnPlatform;
    public LayerMask platform;
    private Collider2D collider;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        collider = GetComponent<Collider2D>();
    }

    void Update()
    {
        isOnPlatform = Physics2D.IsTouchingLayers(collider, platform);

        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) /*insert speech command recognized here*/)
        {
            if (isOnPlatform)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            }
        }
    }

}
