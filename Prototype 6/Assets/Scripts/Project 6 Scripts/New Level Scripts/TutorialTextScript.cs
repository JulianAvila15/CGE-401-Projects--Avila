/*
 * Julian Avila
 * Prototype 6
 * Shows and hides tutorial panel
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialTextScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {

            if (Input.GetMouseButtonDown(0))
            {
                gameObject.SetActive(false);
                Time.timeScale = 1f;
            }
        
    }


}
