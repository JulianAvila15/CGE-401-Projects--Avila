//Julian Avila
//Prototype 1
//Signals the score manager that the player has reached the state of game over
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//attach to player object
public class LoseOnFall : MonoBehaviour
{
    public Text textbox;
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -1)
        {
            ScoreManager.gameOver = true;
        }
    }
}
