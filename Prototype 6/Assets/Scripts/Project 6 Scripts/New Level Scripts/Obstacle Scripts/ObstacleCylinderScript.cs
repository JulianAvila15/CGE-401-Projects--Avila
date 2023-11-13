using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCylinderScript : BaseObstacle
{
    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (NewGameManager.gameOver == false)
        {
            MoveTowardsPlayer(movementSpeed);
        }
    }
}
