using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevelCompleted : MonoBehaviour
{

    public Text winText;
    // Start is called before the first frame update
    void Start()
    {
        winText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(winText.enabled==true && Input.GetKeyDown(KeyCode.Space))
            {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("hit");
            winText.enabled = true;

            if(collision.GetComponent<PlayerPlatformerController>().grounded)
            collision.GetComponent<PlayerPlatformerController>().maxSpeed = collision.GetComponent<PlayerPlatformerController>().jumpTakeOffSpeed = collision.GetComponent<PlayerPlatformerController>().minGroundNormalY = 0 ;
        }
    }



    


}
