using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator anim;
    public Transform attackPoint;
    public LayerMask enemyLayers;
    public float attackRange = 0.5f;
    public int attackDamage = 20;



    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Z))
         {
             Attack();
           }
 
    }
    private void Attack()
    {
        //play attack animation
        anim.SetTrigger("attack");
        //detect enemies in the range of attack
        Collider2D[] hitEnemies =  Physics2D.OverlapCircleAll(attackPoint.position , attackRange , enemyLayers);
        //damage the enemy
        foreach(Collider2D enemy in hitEnemies)
        {
            EnemyHealth enemyHealth = enemy.GetComponent<EnemyHealth>();

            if (enemyHealth != null) 
            {
                enemyHealth.TakeDamage(attackDamage);
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position , attackRange);
    }
 
}
