/*
 * Julian Avila
 * Prototype 7 (Prototype 4)
 * Gives ability to move the ball to the player
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed = 5.0f;
    private float forwardInput;
    [SerializeField] private GameObject focalPoint;
    private bool hasPowerUp;
    private float powerUpStrength = 15.0f;
    public GameObject powerUpIndicator;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.FindGameObjectWithTag("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");


        //move our powerup indicator to the ground below our player
        powerUpIndicator.transform.position = transform.position + new Vector3(0, -.5f, 0);

        if (transform.position.y < -10)
        {
            GameManager.gameOver = true;
            Destroy(gameObject);
        }

    }

    private void FixedUpdate()
    {
        playerRb.AddForce(focalPoint.GetComponent<Transform>().forward * speed * forwardInput);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {
            hasPowerUp = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountDownRoutine());
            powerUpIndicator.gameObject.SetActive(true);
        }
    }

    IEnumerator PowerupCountDownRoutine()
    {
        yield return new WaitForSeconds(7);
        hasPowerUp = false;
        powerUpIndicator.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && hasPowerUp)
        {
            Debug.Log("Player collided with " + collision.gameObject.name + "with powerup set to" + hasPowerUp);

            //get local reference to enemy rigidbody
            Rigidbody enemyRigidBody = collision.gameObject.GetComponent<Rigidbody>();

            //set a vector 3 with a direction away from the player
            Vector3 awayFromPlayer = (collision.gameObject.transform.position-transform.position).normalized;

            //add force away from player
            enemyRigidBody.AddForce(awayFromPlayer * powerUpStrength, ForceMode.Impulse);
        }
    }

    
}
