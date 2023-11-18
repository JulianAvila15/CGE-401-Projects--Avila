/*
 * Julian Avila
 * Prototype 7 (Prototype 4)
 * Gives enemy an AI
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private Rigidbody enemyRigidBody;
    [SerializeField] private GameObject player;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        enemyRigidBody = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
        speed = 2.0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Add force towards force from the player to the enemy

        //vector  for direction from enemy to player
        if (GameManager.gameOver != true)
        {
            Vector3 lookDirection = (player.transform.position - transform.position.normalized);

            enemyRigidBody.AddForce(lookDirection * speed);

            if (transform.position.y < -10)
            {
                Destroy(gameObject);
            }
        }
    }
}
