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
    private Vector3 spawnPosition = new Vector3(25, 0, 0);
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
            float delay = 8f;
            SpawnRandomObstacle();
            yield return new WaitForSeconds(delay);

        }

    }

    void SpawnRandomObstacle()
    {
        int prefabIndex = Random.Range(0, obstaclePrefabs.Length);
        int locationIndex = Random.Range(0, spawnLocations.Length);

        

        spawnPosition = spawnLocations[locationIndex].position;

        //if object is cone and it is spawned on the right side
        if (obstaclePrefabs[prefabIndex].GetComponent<ObstacleConeScript>()!=null && spawnLocations[locationIndex].name == "SpawnZone2")
        {
            Instantiate(obstaclePrefabs[prefabIndex], spawnPosition, Quaternion.Euler(180,180,0));
        }
        else
        Instantiate(obstaclePrefabs[prefabIndex], spawnPosition, spawnLocations[locationIndex].rotation);
    }
}
