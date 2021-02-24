using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoney : MonoBehaviour
{

    public static float Money;
    public Text CurrentPlayerMoneyText;
    public static int PlayerStartingMoney = 100;

    // Start is called before the first frame update
    void Start()
    {
        Money = PlayerStartingMoney;
    }

    private void Update()
    {
        CurrentPlayerMoneyText.text = "Blood Money: $" + Money.ToString();
        Money = Mathf.Clamp(Money,0, Mathf.Infinity);
    }
}
