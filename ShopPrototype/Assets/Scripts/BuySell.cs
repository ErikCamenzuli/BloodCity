using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuySell : MonoBehaviour
{
    //Prices of ammo types
    public int Ammo_Standard = 25;
    public int Ammo_HV = 30;
    public int Ammo_Explosive = 35;
    //money check
    public string popUp;
    private bool HasMoney = true;

    /// <summary>
    /// Inspector Objects
    /// </summary>
    #region BUY VARIABLES
    public GameObject Button_Ammo_Type_1;
    public GameObject Button_Ammo_Type_2;
    public GameObject Button_Ammo_Type_3;
    #endregion
    /// <summary>
    /// Inspector Objects
    /// </summary>
    #region Sell VARIABLES
    public GameObject Sell_Button_Ammo_Type_1;
    public GameObject Sell_Button_Ammo_Type_2;
    public GameObject Sell_Button_Ammo_Type_3;
    #endregion

    public void Update()
    {
        //checking to see if player has money
        NoFunds pop = GameObject.FindGameObjectWithTag("MASTER").GetComponent<NoFunds>();
        pop.BuyCheck(popUp);
    }

    #region BUY FUNCTIONS
    /// <summary>
    /// if the player wants to buy this ammo
    /// it will take money off the players total
    /// </summary>
    public void Ammo_Type_Standard()
    {
        if(Button_Ammo_Type_1 == true)
        {
            PlayerMoney.Money -= Ammo_Standard;
            Debug.Log("Player now has: " + PlayerMoney.Money);
        }
    }
    /// <summary>
    /// if the player wants to buy this ammo
    /// it will take money off the players total
    /// </summary>
    public void Ammo_Type_HV()
    {
        if(Button_Ammo_Type_2 == true)
        {
            PlayerMoney.Money -= Ammo_HV;
            Debug.Log("Player now has: " + PlayerMoney.Money);
        }
    }
    /// <summary>
    /// if the player wants to buy this ammo
    /// it will take money off the players total
    /// </summary>
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
    /// <summary>
    /// if the player wants to sell this ammo
    /// it will give money to the players total
    /// </summary>
    public void Sell_Ammo_Type_Standard()
    {
        if (Button_Ammo_Type_1 == true)
        {
            PlayerMoney.Money += Ammo_Standard/2;
            Debug.Log("Player now has: " + PlayerMoney.Money);
        }
    }
    /// <summary>
    /// if the player wants to sell this ammo
    /// it will give money to the players total
    /// </summary>
    public void Sell_Ammo_Type_HV()
    {
        if (Button_Ammo_Type_2 == true)
        {
            PlayerMoney.Money += Ammo_HV/2;
            Debug.Log("Player now has: " + PlayerMoney.Money);
        }
    }
    /// <summary>
    /// if the player wants to sell this ammo
    /// it will give money to the players total
    /// </summary>
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
