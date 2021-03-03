using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerMoney : MonoBehaviour
{
    //playerprefs string name
    private string StringName = "SaveValString";
    //players money
    public static float Money;
    //UI money text
    public Text CurrentPlayerMoneyText;
    //players starting money
    public static float PlayerStartingMoney = 100f;
    //the income for the player
    public static float IncomeMoney = 500f;
    
    public GameObject NPC;

    private void Update()
    {
        //setting the playerprefs float with the name and a value
        PlayerPrefs.SetFloat(StringName, 5);
        //UI text + showing money value
        CurrentPlayerMoneyText.text = "Blood Money: $" + Money.ToString();
        //money shouldn't go under 0 but can go on endlessly positive
        Money = Mathf.Clamp(Money,0, Mathf.Infinity);

        //getting the targets hp and if hit with damage, target will lose hp
        Target.currentHP -= Gun.damage;
        //checking if the target is 0 
        if (Target.currentHP <= 0)
        {
            //if target is 0, then destroy
            Destroy(NPC);
        }
    }
    /// <summary>
    /// saving the money between scenes
    /// </summary>
    public void SaveSceneValue()
    {
        float playerPrefVal = PlayerPrefs.GetFloat(StringName, Money);
    }
}
