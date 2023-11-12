/*
 * Julian Avila
 * Prototype 6
 * Base class for the cube that also inherits/implements the IDamageable interface
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCube : MonoBehaviour,IDamagable
{
    protected float jumpHeight;
    protected int health;
    protected Rigidbody rb;
    protected bool isGrounded,gotHit;
    [SerializeField] protected Material normal,blink;

    protected abstract void OnCollisionEnter(Collision collision);

    protected abstract void OnTriggerEnter(Collider collision);
    // Start is called before the first frame update
    void Start()
    {
        jumpHeight = 3.0f;
        health = 3;
        isGrounded = false;
        gotHit = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Implemented from interface
    public void TakeDamage(int amount)
    {
        health -= amount;
    }

  


}
