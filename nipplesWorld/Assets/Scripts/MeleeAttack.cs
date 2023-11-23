using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MeleeAttack : LosingHealth
{
    [SerializeField] private bool attack = true;

    [SerializeField] private GameObject attackPos;
    [SerializeField] public float attackRange;
    [SerializeField] private LayerMask attackLayerMask;

    [SerializeField] private int damage;
    public void Attack()
    {

        if (attack == true)
        {
        //    Attak1.Play();
            attack = false;

//            anim.SetTrigger("Attack");
            Collider[] enemiscToDamage = Physics.OverlapSphere(attackPos.transform.position, attackRange, attackLayerMask);
            for (int i = 0; i < enemiscToDamage.Length; i++)
            {
                enemiscToDamage[i].GetComponent<LosingHealth>().TakeDamage(damage);

        //        AddScore(3);
            }
            Invoke("AttackReset", 1);


        }
    }

    private void AttackReset()
    {
        attack = true;
    }
}
