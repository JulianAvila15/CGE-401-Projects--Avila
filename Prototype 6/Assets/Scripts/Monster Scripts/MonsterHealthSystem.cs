using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterHealthSystem: Target
{

    public float damage;
    [SerializeField] private float attackSpeed;
    [SerializeField] private float maxHealth;
    [SerializeField] private bool canAttack,isDead;
    private Animator anim = null;
    private float time, timeDelay;

    // Start is called before the first frame update
    void Start()
    {
        InitVariables();
        time = 0f;
        timeDelay = 10f;
    }

    // Update is called once per frame
    void Update()
    {


        if (health <= 0)
        {
            anim.SetTrigger("Dead");
            anim.SetBool("IsDead", true);
        }

        if (anim.GetBool("IsDead")==true)
        {
            time += 1f * Time.deltaTime;

            if (time >= timeDelay*1)
            {
                Die();
            }
        }
    }

    public override void TakeDamage(float amount)
    {
        if(anim.GetBool("IsDead") == false)
        anim.SetTrigger("Hurt");
        health -= amount;


    }
    public override void InitVariables()
    {
        health = 60;
        attackSpeed = 1.5f;
        canAttack = false;
        damage = 50f;
        anim = GetComponentInChildren<Animator>();
    }
}
