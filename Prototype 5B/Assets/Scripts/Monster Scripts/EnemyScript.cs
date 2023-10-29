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
   [SerializeField] private GameObject target;
    [SerializeField] private float stoppingDistance = 2.5f;
      private MonsterStats stats = null;
     private Animator anim = null;
    float distanceToTarget;


    // Start is called before the first frame update
    void Start()
    {
        ObtainReferences();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            MoveToTarget();
            distanceToTarget = Vector3.Distance(target.transform.position, transform.position);
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

    void AttackTarget(MonsterStats statsDamage)
    {
        anim.SetTrigger("Attack");
        target.GetComponent<PlayerStats>().TakeDamage((statsDamage.damage)/60);
    }

    void RotateToTarget()
    {
        transform.LookAt(target.transform.position);
    }

    void ObtainReferences()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponentInChildren<Animator>();
        stats = GetComponent<MonsterStats>();
    }

}
