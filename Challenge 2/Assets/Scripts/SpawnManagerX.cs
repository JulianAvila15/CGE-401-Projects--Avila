using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(SpawnRandomBallwithCoroutine());
    }

    IEnumerator SpawnRandomBallwithCoroutine()
    {
        //add a 3 second delay before first spawning objects
        yield return new WaitForSeconds(3f);

        while (true)
        {
            SpawnRandomBall();
            float randomDelay = Random.Range(3.0f, 5.0f);
            yield return new WaitForSeconds(randomDelay);
        }

    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        //pick random ball
        int prefabIndex = Random.Range(0, ballPrefabs.Length);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[prefabIndex], spawnPos, ballPrefabs[prefabIndex].transform.rotation);
    }

}
