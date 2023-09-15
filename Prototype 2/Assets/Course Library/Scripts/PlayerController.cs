using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput, speed = 10.0f, xRange = 14;
  
    // Update is called once per frame
    void Update()
    {
        //Get Horizontal Input
        horizontalInput = Input.GetAxis("Horizontal");

        //transform horizontal with input
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //Keep player in bounds
        if(transform.position.x<-xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
}
