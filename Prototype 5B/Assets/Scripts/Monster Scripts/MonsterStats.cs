using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterStats : Target
{

    public float damage;
    [SerializeField] private float attackSpeed;
    [SerializeField] private float maxHealth;
    [SerializeField] private bool canAttack,isDead;

    // Start is called before the first frame update
    void Start()
    {
        InitVariables();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DealDamage()
    {
        //Damage Functionality

    }

    public override void InitVariables()
    {
        health = 100;
        attackSpeed = 1.5f;
        canAttack = false;
        damage = 50f;
    }
}
