using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoFunds : MonoBehaviour
{
    public GameObject TextBoxPopUp;
    public Text PopUpText;
    
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
