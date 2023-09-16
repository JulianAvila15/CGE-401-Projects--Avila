/*
 * Julian Avila
 * Prototype 2
 * Detects collisions with other objects
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//attach to food prefab
public class DetectCollisions : MonoBehaviour
{
    private DisplayScore displayScoreScript;
   
    void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();
    }

    private void OnTriggerEnter(Collider other)
    {
        displayScoreScript.score++;
        Destroy(other.gameObject);
        Destroy(gameObject);
        
    }
}
