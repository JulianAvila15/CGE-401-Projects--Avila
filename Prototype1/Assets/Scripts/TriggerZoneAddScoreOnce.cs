//Julian Avila
//Prototype 1
//Allows the player to earn points when the player collides with a trigger zone
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach this to a trigger zone
public class TriggerZoneAddScoreOnce : MonoBehaviour
{
    private bool trigger = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")&&!trigger)
        {
            trigger = true;
            ScoreManager.score++;
        }
    }
}
