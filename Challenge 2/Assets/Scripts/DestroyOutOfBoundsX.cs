﻿/*
 * Julian Avila
 * Challenge 2
 * Destroys objects once they reach an out of bounds position
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -60;
    private float bottomLimit = -9;
    private HealthSystem healthSystemScript;

    void Start()
    {
        healthSystemScript = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            //grab health sys script and call the take damage method
            healthSystemScript.TakeDamage();
            Destroy(gameObject);
        }

    }
}
