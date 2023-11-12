/*
 * Julian Avila
 * Prototype 6
 * Right Cube object that inherits from the base cube class
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCube : BaseCube
{
    // Start is called before the first frame update
    void Start()
    {

        jumpHeight = -9.0f;
        health = 10;
        rb = GetComponent<Rigidbody>();
        isGrounded = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(Vector3.up* 9.81f, ForceMode.Acceleration);//Adds Anti-Gravity
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow)&&isGrounded==true)
        {
            rb.AddForce(Vector2.up * jumpHeight, ForceMode.Impulse);
            isGrounded = false;
        }

        if (health <= 0)
        {
            NewGameManager.gameOver = true;
        }

        if(gotHit == true)
        {

        }
    }

    protected override void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    protected void EnableBlink()
    {
        gameObject.GetComponent<Renderer>().material = blink;
    }

    protected void DisableBlink()
    {

        gameObject.GetComponent<Renderer>().material = normal;
    }

    protected override void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            TakeDamage(1);
            Invoke("EnableBlink", 0f);
            Invoke("DisableBlink", .1f);

        }
    }

   



}
