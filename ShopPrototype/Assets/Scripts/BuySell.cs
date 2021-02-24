using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuySell : MonoBehaviour
{
    public int Ammo_Standard = 25;
    public int Ammo_HV = 30;
    public int Ammo_Explosive = 35;
    public string popUp;
    private bool HasMoney = true;


    #region BUY VARIABLES
    public GameObject Button_Ammo_Type_1;
    public GameObject Button_Ammo_Type_2;
    public GameObject Button_Ammo_Type_3;
    #endregion

    #region Sell VARIABLES
    public GameObject Sell_Button_Ammo_Type_1;
    public GameObject Sell_Button_Ammo_Type_2;
    public GameObject Sell_Button_Ammo_Type_3;
    #endregion

    public void Update()
    {
        NoFunds pop = GameObject.FindGameObjectWithTag("MASTER").GetComponent<NoFunds>();
        pop.BuyCheck(popUp);
    }

    #region BUY FUNCTIONS
    public void Ammo_Type_Standard()
    {
        if(Button_Ammo_Type_1 == true)
        {
            PlayerMoney.Money -= Ammo_Standard;
            Debug.Log("Player now has: " + PlayerMoney.Money);
        }
    }

    public void Ammo_Type_HV()
    {
        if(Button_Ammo_Type_2 == true)
        {
            PlayerMoney.Money -= Ammo_HV;
            Debug.Log("Player now has: " + PlayerMoney.Money);
        }
    }

    public void Ammo_Type_Explosive()
    {
        if(Button_Ammo_Type_3 == true)
        { 
            PlayerMoney.Money -= Ammo_Explosive;
            Debug.Log("Player now has: " + PlayerMoney.Money);
        }
    }



    #endregion

    #region SELL FUNCTIONS
    public void Sell_Ammo_Type_Standard()
    {
        if (Button_Ammo_Type_1 == true)
        {
            PlayerMoney.Money += Ammo_Standard/2;
            Debug.Log("Player now has: " + PlayerMoney.Money);
        }
    }

    public void Sell_Ammo_Type_HV()
    {
        if (Button_Ammo_Type_2 == true)
        {
            PlayerMoney.Money += Ammo_HV/2;
            Debug.Log("Player now has: " + PlayerMoney.Money);
        }
    }

    public void Sell_Ammo_Type_Explosive()
    {
        if (Button_Ammo_Type_3 == true)
        {
            PlayerMoney.Money += Ammo_Explosive/2;
            Debug.Log("Player now has: " + PlayerMoney.Money);
        }
    }
    #endregion

}
