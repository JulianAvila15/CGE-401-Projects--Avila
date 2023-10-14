using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextScoreDisplay : MonoBehaviour
{
    public Text scoreText;
    //public GemBehaviour gemObject;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();

        scoreText.text = "Score = 0";
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: "+ GemBehaviour.score;
        
    }
}
