using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoFunds : MonoBehaviour
{
    //UI
    public GameObject TextBoxPopUp;
    //Text
    public Text PopUpText;
    /// <summary>
    /// checking is the player has enough money
    ///     if the player has 0 then activate the popup textbox and text
    ///  else stay deactivated
    /// </summary>
    /// <param name="text"></param>
    public void BuyCheck(string text)
    {
        if (PlayerMoney.Money <= 0)
        {
            TextBoxPopUp.SetActive(true);
            PopUpText.text = text;

        }
        else if (PlayerMoney.Money >= 1)
        {
            TextBoxPopUp.SetActive(false);
            PopUpText.text = text;
        }
    }
}
