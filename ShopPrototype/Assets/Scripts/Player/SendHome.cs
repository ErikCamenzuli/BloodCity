using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SendHome : MonoBehaviour
{
    [SerializeField] private Transform player;
    /// <summary>
    /// if the player hits the collision box for whatever object that
    /// script is on, it will send the player to the mainmenu
    /// unlock the cursor and set it visible
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("MainMenu");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
