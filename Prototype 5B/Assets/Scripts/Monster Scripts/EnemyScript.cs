/*Julian Avila
 * Prototype 5B
 * Provides enemy movement and attacks*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    private NavMeshAgent agent = null;
    private GameObject target;
    [SerializeField] private float stoppingDistance = 2.5f;
     private MonsterHealthSystem stats = null;
     private Animator anim = null;
    float distanceToTarget;
  


    // Start is called before the first frame update
    void Start()
    {
        ObtainReferences();
        target = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {

            distanceToTarget = Vector3.Distance(target.transform.position, transform.position);

            if (anim.GetBool("IsDead") != true&&distanceToTarget<20)
            MoveToTarget();
           

        }

    }

    void MoveToTarget()
    {
        agent.SetDestination(target.transform.position);
       
        RotateToTarget();
        
        anim.SetFloat("Blend", 1f, .3f, Time.deltaTime);
        if (distanceToTarget <= stoppingDistance)
        {
            anim.SetFloat("Blend", 0f);
            //Attack
            AttackTarget(stats);
        }
       
    }

    void AttackTarget(MonsterHealthSystem statsDamage)
    {
        anim.SetTrigger("Attack");
        target.GetComponent<PlayerHealthSystem>().TakeDamage((statsDamage.damage)/300);
    }

    void RotateToTarget()
    {
        transform.LookAt(target.transform.position);
    }

    void ObtainReferences()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponentInChildren<Animator>();
        stats = GetComponent<MonsterHealthSystem>();
    }

}
