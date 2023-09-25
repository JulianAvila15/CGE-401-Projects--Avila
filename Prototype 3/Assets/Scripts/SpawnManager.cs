/*Julian Avila
 * Prototype 3
 * Spawn obstacles in the scene
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    private Vector3 spawnPosition = new Vector3(25, 0, 0);
    private float startDelay = 2.0f, repeatRate = 2.0f;
    private int randomPrefabIndex;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    void SpawnObstacle()
    {
        if(playerControllerScript.gameOver==false)
        Instantiate(obstaclePrefab[randomPrefabIndex], spawnPosition, obstaclePrefab[randomPrefabIndex].transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        randomPrefabIndex = Random.Range(0,obstaclePrefab.Length);
    }
}
