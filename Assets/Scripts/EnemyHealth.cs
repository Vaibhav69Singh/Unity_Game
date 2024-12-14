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
        anim = GetComponent<Animator>();
    }
    
    public void TakeDamage(int damage)
    {
        currHealth -= damage;

        //use the second if condition after adding animation

        if (currHealth <= 0) 
        {
            Die();
            Destroy(gameObject);
        }
    }

    public void Die()
    {
        anim.SetTrigger("die");
    }

}
