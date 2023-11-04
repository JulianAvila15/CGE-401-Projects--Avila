/*Julian Avila
Prototype 5B
Informs the player when they win and when they can restart the game once collided with the win zone*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WinZone : MonoBehaviour
{
    [SerializeField] private Text winText;
    // Start is called before the first frame update
    void Start()
    {
        winText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            winText.enabled = true;
            GameManager.won = true;
        }
    }
}
