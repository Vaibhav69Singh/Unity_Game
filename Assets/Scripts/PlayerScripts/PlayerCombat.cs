using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator anim;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Attack();
        }
    }
    public void Attack()
    {
        //play attack animation
        anim.SetTrigger("attack");
        //detect enemies in the range of attack
        //damage the enemy
    }
}
