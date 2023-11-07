using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour
{
    public int damageBonus;

    public Enemy enemyHoldingWeapon;

    

    public void recharge()
    {
        Debug.Log("Recharging Weapon");
    }
    // Use this for initialization
    private void Awake()
    {
        enemyHoldingWeapon = gameObject.GetComponent<Enemy>();
        EnemyEatsWeapon(enemyHoldingWeapon);
    }


    protected void EnemyEatsWeapon(Enemy enemy)
    {
        Debug.Log("Enemy eats weapon");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
