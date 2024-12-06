using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private Animator anim;
    public int maxHealth = 40;
    public int currHealth;
    void Start()
    {
        currHealth = maxHealth;
    }
    
    public void TakeDamage(int damage)
    {
        currHealth -= damage;

        //use the second if condition after adding animation
        if (currHealth < 0) 
        {
            Destroy(gameObject);
        }

       /* if (currHealth < 0) 
        {
            Die();
        }*/
    }

   /* private void Die()
    {
        Destroy(gameObject);
        anim.SetTrigger("die");
    }*/

}
