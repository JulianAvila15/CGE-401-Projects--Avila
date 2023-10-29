using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerStats : MonoBehaviour
{
    public float health = 300f;
    public Text healthText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + health;

        if(health<=0)
        {
            Destroy(gameObject);
        }
    }

   public void TakeDamage(float damageDone)
    {
        health -= damageDone;
    }

   
}
