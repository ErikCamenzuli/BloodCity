using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public static int currentHP;
    private static int fullHP = 50;
    private bool isDead = false;

    private void Awake()
    {
        currentHP = fullHP;
    }

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

    public void ObjDead()
    {
        Destroy(this.gameObject);
    }



}
