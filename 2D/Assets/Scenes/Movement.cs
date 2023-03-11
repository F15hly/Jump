using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{ 
    public float speed;
    public Rigidbody2D rb;
    //public float jump;

    float mx;

    private void Update()
    {
        mx = Input.GetAxisRaw("Horizontal");

        //if (Input.GetButtonDown("Jump"))
        //{
        //  JF();
        //}
    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(mx * speed, rb.velocity.y);
        rb.velocity = movement;

    }
    //void JF()
    // {
    //  Vector2 movement = new Vector2(rb.velocity.x, jump);
    //  rb.velocity = movement;
    //}
}
