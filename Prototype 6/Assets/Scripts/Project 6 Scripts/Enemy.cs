using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour,IDamagable
{

    protected float speed;
    protected int health;

    [SerializeField] protected Weapon weapon;

    virtual protected void Awake()
    {
        weapon = gameObject.AddComponent<Weapon>();
        speed = 5.0f;
        health = 100;

        weapon.damageBonus = 10;
    }

    protected abstract void Attack(int amount);
    public abstract void TakeDamage(int amount);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
