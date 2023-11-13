/*
 * Julian Avila
 * Prototype 6
 * Spawns Obstacles for the player to avoid
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public BaseObstacle[] obstaclePrefabs;//Polymorphised class, "BaseObstacle"
    [SerializeField] private Transform[] spawnLocations;
    private float startDelay = 2.0f, repeatRate = 2.0f;
    private int randomPrefabIndex;
    // Start is called before the first frame update

    // Start is called before the first frame update
    void Start()
    {
        StartSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void StartSpawn()
    {
        StartCoroutine(SpawnRandomPrefabwithCoroutine());
    }

    IEnumerator SpawnRandomPrefabwithCoroutine()
    {

        while (NewGameManager.gameOver == false)
        {
            float delay = 4f;
            SpawnRandomObstacle();
            yield return new WaitForSeconds(delay);

        }

    }

    void SpawnRandomObstacle()
    {
        int prefabIndex = Random.Range(0, obstaclePrefabs.Length);

            Instantiate(obstaclePrefabs[prefabIndex], spawnLocations[1].position, Quaternion.Euler(180, 180, 0));
            Instantiate(obstaclePrefabs[prefabIndex], spawnLocations[0].position, Quaternion.Euler(0, 180, 0));
    }
}
