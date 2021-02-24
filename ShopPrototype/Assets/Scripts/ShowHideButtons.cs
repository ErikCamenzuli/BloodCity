using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideButtons : MonoBehaviour
{

    public GameObject Panel;
    
    public void OpenPanel()
    {
        if(Panel != null)
        {
            Panel.SetActive(true);
        }
        else if(Panel == null)
        {
            return;
        }
    }
    
    public void ClosePanel()
    {
        if(Panel != null)
        {
            Panel.SetActive(false);
        }
        else if (Panel == null)
        {
            return;
        }
    }


}
