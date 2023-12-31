/*Julian Avila
 * Prototype 5B
 * Allows players to shoot with raycasts*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWithRayCasts : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public Camera cam;
    public ParticleSystem muzzleFlash;
    public float hitForce = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")&&GameObject.FindGameObjectWithTag("Player")!=null)
        {
            Shoot();
        }



    }

    void Shoot()
    {
        //At the beginning of the Shoot() method, play the particle effect
        muzzleFlash.Play();
        RaycastHit hitInfo;


        if(Physics.Raycast(cam.transform.position,cam.transform.forward,out hitInfo, range))
        {
            Debug.Log(hitInfo.transform.gameObject.name);

            //Get the target script off the hit object

            Target target = hitInfo.transform.gameObject.GetComponent<Target>();

            //If target script was found, make target take damage
            if(target!=null)
            {
                target.TakeDamage(damage);
                
                //if shot hits rigit body add a force
                if(hitInfo.rigidbody!=null)
                {
                    hitInfo.rigidbody.AddForce(cam.transform.TransformDirection(Vector3.forward)*hitForce,ForceMode.Impulse);
                }
            }

        }
    }
}
