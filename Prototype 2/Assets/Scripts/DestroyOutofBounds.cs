/*
 * Julian Avila
 * Prototype 2
 * Destroys objects when they reach an out of bounds position
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    public float topBound = 20, bottomBound = -10;
    private HealthSystem healthSystemScript;

    void Start()
    {
        healthSystemScript = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z<bottomBound)
        {
            //grab health sys script and call the take damage method
            healthSystemScript.TakeDamage();
            Destroy(gameObject);
        }
    }
}
