using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    //current hp for target
    public static int currentHP;
    //starting value for target
    private static int fullHP = 50;
    //is target dead?
    private bool isDead = false;

    private void Awake()
    {
        //setting the current hp to full
        currentHP = fullHP;
    }
    /// <summary>
    /// taking currenthp from whatever the damage output is
    /// adding money to the player with the income variable
    /// checking if the current hp of target is 0
    ///     call ObjDead() and set isDead to true
    /// </summary>
    /// <param name="TakeDamage"></param>
    public void DamageTaken(int TakeDamage)
    {
        currentHP -= TakeDamage;
        PlayerMoney.Money += PlayerMoney.IncomeMoney;
        if (currentHP <= 0)
        {
            if (isDead == false)
            {
                ObjDead();
                isDead = true;
            }
        }
    }
    /// <summary>
    /// destroying gameobject
    /// </summary>
    public void ObjDead()
    {
        Destroy(this.gameObject);
    }



}
