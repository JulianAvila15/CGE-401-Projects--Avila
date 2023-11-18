/*
 * Julian Avila
 * Prototype 7 (Prototype 4)
 * Rotates Camera when the horizontal axis changes
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotationSpeed;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up,horizontalInput * rotationSpeed*Time.deltaTime);
    }
}
