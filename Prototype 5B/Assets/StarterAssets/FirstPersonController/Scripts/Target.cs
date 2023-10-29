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

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
            Die();
    }

    public virtual void InitVariables()
    {
        health = 50f;
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
