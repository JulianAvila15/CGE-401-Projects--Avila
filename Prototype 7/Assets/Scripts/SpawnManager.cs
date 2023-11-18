/*
 * Julian Avila
 * Prototype 7 (Prototype 4)
 * Spawns enemies and powerups
 */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 9;
    [SerializeField] private int numOfEnemies;
    [SerializeField] private GameObject powerUpPrefab;

    public int waveNumber = 1;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(waveNumber);
    }

    private void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            //Instantiate the enemy in a random position
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }

    // Update is called once per frame
    void Update()
    {
        numOfEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if(numOfEnemies == 0 &&GameManager.gameOver==false)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            SpawnPowerUp(1);
            
        }

        if (waveNumber > 10)
            GameManager.gameOver = true;

    }

    private void SpawnPowerUp(int numOfPowerUps)
    {
        for (int i = 0; i < numOfPowerUps ; i++)
        {
            // //Instantiate the power up in a random position
            Instantiate(powerUpPrefab, GenerateSpawnPosition(), powerUpPrefab.transform.rotation);
        }
    }
}
