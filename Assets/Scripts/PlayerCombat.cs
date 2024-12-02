using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator anim;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    
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
