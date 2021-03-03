using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    //UI
    [SerializeField] private GameObject pausePanel;

    void Start()
    {
        //always setting the pause UI unactive
        pausePanel.SetActive(false);
        //checking if there's no set gameobject to the inspector
        if (pausePanel != null)
            return;
    }

    void Update()
    {
        //checking is escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //activating in hierarchy and setting cursor to true
            if (!pausePanel.activeInHierarchy)
            {
                Cursor.visible = true;
                PauseGame();
            }
            //if pressed, hides pause panel and hides cursor
            else if (pausePanel.activeInHierarchy)
            {
                Cursor.visible = false;
                UnpauseGame();
            }
        }

        if (pausePanel != null)
        {
            return;
        }

    }
    /// <summary>
    /// if game is paused the set time scale to 0 (freezing game)
    /// activating pausepanel
    /// </summary>
    public void PauseGame()
    {
        Time.timeScale = 0f;
        pausePanel.SetActive(true);
        Debug.Log("Paused!");
    }
    /// <summary>
    /// if game is unpaused the set time scale to 1 (unfreezing game)
    /// de-activating pausepanel
    /// setting the cursor to invisible
    /// </summary>
    public void UnpauseGame()
    {
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
        Cursor.visible = false;
        Debug.Log("Unpaused!");
    }
}
