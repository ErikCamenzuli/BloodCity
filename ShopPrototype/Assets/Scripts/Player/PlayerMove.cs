using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //using a character controller
    public CharacterController controller;
    //players speed
    public float speed = 15f;
    //velocity for player
    Vector3 velocity;
    //gravity
    public float gravity = -9.81f;
    //drop in velocity
    public float velocityDrop;
    //ground check
    public Transform groundCheck;
    //distance to ground
    public float distanceToGround = 0.4f;
    //layer mask for inspector
    public LayerMask groundMask;
    //is player grounded?
    bool isGrounded;
    //players jump height
    public float jumpHeight;

    // Update is called once per frame
    void Update()
    {
        //creating a sphere and checking if it collides with anything on the ground
        isGrounded = Physics.CheckSphere(groundCheck.position, distanceToGround, groundMask);
        //checking if the player is grounded
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = velocityDrop;
        }
        //getting x and z axis for horizontal and vertical
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        //setting move directions to transform right/forward * x/z 
        Vector3 moveDirection = transform.right * x + transform.forward * z;

        controller.Move(moveDirection * speed * Time.deltaTime);
        //checking if the jump key is pressed (space bar)
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            //velocity for jumping with how high, the drop off and impact of gravity
            velocity.y = Mathf.Sqrt(jumpHeight * velocityDrop * gravity);
        }

        //y= 0.5(gravity * time^2)
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
