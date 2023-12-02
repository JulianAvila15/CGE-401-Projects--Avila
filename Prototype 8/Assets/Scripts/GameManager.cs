/*Julian Avila
 * Prototype 8
 *Manages game events such as game over and score
 */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    private float spawnRate= 1.0f;
    public TextMeshProUGUI scoreText,gameOverText;
    private int score;

    public bool isGameActive;

    public GameObject restartButton,titleScreen;
    
    public void StartGame(int difficulty)
    {
        isGameActive = true;
        StartCoroutine(SpawnTarget());
        score = 0;
        UpdateScore(score);
        restartButton.gameObject.SetActive(false);
        titleScreen.SetActive(false);
        spawnRate /= difficulty;
    }

   public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        isGameActive = false;
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    IEnumerator SpawnTarget()
    {
       while(isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);

            int index = UnityEngine.Random.Range(0, targets.Count);
            
            //spawn the prefab at the randomly selected index
            Instantiate(targets[index]);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
