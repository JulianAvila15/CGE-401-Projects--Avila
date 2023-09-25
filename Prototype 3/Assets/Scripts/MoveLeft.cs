/*Julian Avila
 * Prototype 3
 * Makes obstacles move to the left of the screen
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30f;
    private float leftBound = -15;
    private PlayerController PlayerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        PlayerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerControllerScript.gameOver==false)
        //Move obstacle to the left 
        transform.Translate(Vector3.left * Time.deltaTime * speed);

        //If we are out of bounds to the left and the gameObject is a 'obstacle',then destroy
        if (transform.position.x < leftBound && gameObject.CompareTag("obstacle"))
        {
            Destroy(gameObject);
        }

    }
}
