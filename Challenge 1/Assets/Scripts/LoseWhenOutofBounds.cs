//Julian Avila
//Challenge 1
//Signals the score manager that the player has reached the state of game over
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseWhenOutofBounds : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 80|| transform.position.y < -51)
        {
            ScoreManager.gameOver = true;
        }
    }
}
