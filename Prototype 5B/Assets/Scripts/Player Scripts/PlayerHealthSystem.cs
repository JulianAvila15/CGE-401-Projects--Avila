/*Julian Avila
 * Prorotype 5B
 * Gives player a health system*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealthSystem : MonoBehaviour
{
    public float health = 300f;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider.minValue = 0;
        slider.maxValue = health;
        slider.value = slider.maxValue;
     
    }

    // Update is called once per frame
    void Update()
    {

        if(health<=0)
        {
            Destroy(gameObject);
            GameManager.isDead = true;
        }
    }

   public void TakeDamage(float damageDone)
    {
        health -= damageDone;
        slider.value = health;
    }

   
}
