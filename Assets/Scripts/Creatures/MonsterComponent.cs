using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterComponent : MonoBehaviour
{
    // handles animation and combat

    #region Components
    Animator anim;
    #endregion

    #region Data
    [SerializeField]
    int damage;
    //[SerializeField]
    //float attackRange; //Attack are collider-based

    bool canAttack = true;

    #endregion

    PlayerController pc;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!canAttack)
            return;

        if (other.CompareTag("Purple") || other.CompareTag("Yellow"))
        {
            //consider if SHOULD-attack, or always attack if possilbe
            //perhaps a cool down or a long animation that can get canceled

            //attack, if so decided
            canAttack = false;
            anim.SetTrigger("Attack"); //this starts the attack animation, which will prompt the "AttackHit()" method 
            pc = other.GetComponent<PlayerController>();
            if(!pc)
            {
                pc = other.GetComponentInParent<PlayerController>();
            }
            if (!pc)
            {
                pc = other.GetComponentInChildren<PlayerController>();
            }

            pc.GetDamage(damage);
        }
    }

    public void AttackHit()
    {
        
    }

}
