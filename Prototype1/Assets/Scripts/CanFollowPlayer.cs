//Julian Avila
//Prototype 1
//Allows camera to follow player with some offset distance

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanFollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -10);
    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
