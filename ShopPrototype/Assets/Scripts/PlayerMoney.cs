using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerMoney : MonoBehaviour
{
    private string StringName = "SaveValString";
    public static float Money;
    public Text CurrentPlayerMoneyText;

    public static float PlayerStartingMoney = 100f;
    public static float IncomeMoney = 500f;

    public GameObject NPC;

    private void Update()
    {
        PlayerPrefs.SetFloat(StringName, 5);
        CurrentPlayerMoneyText.text = "Blood Money: $" + Money.ToString();
        Money = Mathf.Clamp(Money,0, Mathf.Infinity);


        Target.currentHP -= Gun.damage;

        if (Target.currentHP <= 0)
        {
            Destroy(NPC);
        }
    }

    public void SaveSceneValue()
    {
        float playerPrefVal = PlayerPrefs.GetFloat(StringName, Money);
    }
}
