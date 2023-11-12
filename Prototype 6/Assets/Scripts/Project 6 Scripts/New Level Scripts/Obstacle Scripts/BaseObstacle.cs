/*
 * Julian Avila
 * Prototype 6
 * Base object for the obstacles
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseObstacle : MonoBehaviour
{
    protected float movementSpeed;
    protected float boundary = -20;
    // Start is called before the first frame update
    void Awake()
    {
        movementSpeed = 4.0f;
    }

    // Update is called once per frame
    void Update()
    {
        

    }

   protected void MoveTowardsPlayer(float speedOfMovement)
    {
        transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
    }
}
