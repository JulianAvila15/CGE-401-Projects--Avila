/*
 * Julian Avila
 * Prototype 6
 * Left Cube object that inherits from the base cube class
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftCube : BaseCube
{
    [SerializeField] Slider healthBar;
    // Start is called before the first frame update
    void Start()
    {
        
        jumpHeight = 9.0f;
        health = 100;
        rb = GetComponent<Rigidbody>();
        isGrounded = true;

        healthBar.maxValue = health;
        healthBar.minValue = 0;
        healthBar.value = healthBar.maxValue;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded == true)
        {
            isGrounded = false;
            rb.AddForce(Vector2.up * jumpHeight, ForceMode.Impulse);
        }


        if (health <= 0)
        {
            NewGameManager.gameOver = true;
        }

        if (NewGameManager.firstPlayerScore >= 10)
        {
            NewGameManager.gameOver = true;
            NewGameManager.won = true;
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
            TakeDamage(10);
            healthBar.value = health;
            Invoke("EnableBlink", 0f);
            Invoke("DisableBlink", .1f);

        }
    }

    protected void OnTriggerExit(Collider other)
    {
        //If entered score trigger
        if (other.gameObject.CompareTag("ScoreTrigger"))
        {
            NewGameManager.firstPlayerScore++;

        }


    }


}
