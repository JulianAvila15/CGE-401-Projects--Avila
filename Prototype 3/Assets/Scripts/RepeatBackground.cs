/*Julian Avila
 * Prototype 3
 * Moves the background to the left repeatedly 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPosition;
    private float repeatWidth;
    // Start is called before the first frame update
    void Start()
    {
        //save start position
        startPosition = transform.position;

        //set repeatWidth to 1/2 of the background
        repeatWidth = GetComponent<BoxCollider>().size.x/2;
    }

    // Update is called once per frame
    void Update()
    {
        //if the background is furthter to the left than the repeatWdith, then reset it to the startPosition

        if(transform.position.x + repeatWidth < startPosition.x )
        {
            transform.position = startPosition;
        }
        
    }
}
