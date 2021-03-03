using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagement : MonoBehaviour
{
    /// <summary>
    /// loads level
    /// can be set in the inspector
    /// </summary>
    /// <param name="levelName"></param>
    public void SelectLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
    /// <summary>
    /// quits game
    /// </summary>
    public void quitGame()
    {
        Application.Quit();
    }

}
