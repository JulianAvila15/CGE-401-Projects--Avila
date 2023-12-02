/*
 * Julian Avila
 * Prototype 8
 * Target script for target objects, gives them physics and health
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRB;
    private float minSpeed = 12;
    private float maxSpeed = 16;
    private float maxTorque = 10;
    private float xRange = 4;
    private float ySpawnPos = -6;

    private GameManager gameManager;

    public ParticleSystem explosionParticle;

    public int pointValue=0;
    // Start is called before the first frame update
    void Start()
    {
        targetRB = GetComponent<Rigidbody>();

        //Add force upwards multiplied by a randomized speed
        targetRB.AddForce(RandomForce(), ForceMode.Impulse);

        //Add a random torque (rotational force) with a randomized 
        targetRB.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);

        //set the position with a randomized x value
        transform.position = RandomPosition();

        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private Vector3 RandomPosition()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
    }

    private Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

   private float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }

    private void OnMouseDown()
    {
        if (gameManager.isGameActive)
        {
            Destroy(gameObject);
            gameManager.UpdateScore(pointValue);
            Instantiate(explosionParticle, transform.position, transform.rotation);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(gameObject.CompareTag("Red"))
        {
            gameManager.GameOver();
        }

        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
