using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideButtons : MonoBehaviour
{
    //UI
    public GameObject Panel;
    /// <summary>
    /// opening and closing of panel
    /// </summary>
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
