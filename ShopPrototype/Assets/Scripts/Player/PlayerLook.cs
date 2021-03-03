using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    //mouse sensitivity for camera/player
    public float mouseSens = 100f;
    public Transform player;
    //rotation for x
    private float xRotate = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //locking cursor and setting invisible
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //getting the X and Y axis for the mouse then * by the mousesens * deltatime
        float mouseInX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseInY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        xRotate -= mouseInY;
        xRotate = Mathf.Clamp(xRotate, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotate, 0f, 0f);
        player.Rotate(Vector3.up * mouseInX);
    }
}
