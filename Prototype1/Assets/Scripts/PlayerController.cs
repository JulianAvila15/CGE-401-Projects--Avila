﻿//Julian Avila
//Prototype 1
//Allows player to move vehicle

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public float forwardInput;
    public float horizontalInput;
   
 
    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        //allows us to move forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput );

        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime*horizontalInput);

    }
}
