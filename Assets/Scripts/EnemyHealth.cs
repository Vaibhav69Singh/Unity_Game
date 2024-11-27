using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
   public float enemyHealth; 
   public void setHealth(int health)
    {
        if (GameObject.CompareTag("Goblin"))
        {
            enemyHealth = 25;
        }
    }
   public void takeDamage(int damage)
    {
        enemyHealth -= damage;
    }
    
}
