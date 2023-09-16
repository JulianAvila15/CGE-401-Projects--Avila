/*
 * Julian Avila
 * Challenge 2
 * Allows the player to summon a dog to catch the falling balls, in moderation
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public bool canCallDog;
  
    //Every 2 seconds, allow the player to summon a dog
    void Start()
    {
            InvokeRepeating("CanSummonDog", 0f, 2.0f);
    }

    // Update to check to see if the player can summon a dog
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canCallDog)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            canCallDog = false; //Once a dog is summoned, the player must wait before they can summon another one
        }
    }
    //After some time, the player can summon a dog
    void CanSummonDog()
    {
        canCallDog = true;
    }
}
