/*
 * Julian Avila
 * Prototype 2
 * Allows player to shoot food prefabs
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPrefab : MonoBehaviour
{
    public GameObject prefabToShoot;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefabToShoot,transform.position,prefabToShoot.transform.rotation);
        }
    }
}
