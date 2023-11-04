/*Julian Avila
Prototype 5B
Gives shootable objects health and a force*/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
            Die();
    }

    public virtual void InitVariables()
    {
        health = 50f;
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
