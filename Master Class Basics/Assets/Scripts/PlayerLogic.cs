using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    //charactar movement var fields
    CharacterController characterController;

    [SerializeField]
    float movementSpeed = 1.5f;
    [SerializeField]
    float jumpHeight = 0.15f;
    [SerializeField]
    float gravity = 0.01f;

    float horizontalInput;

    int jumpCount = 0;

    [SerializeField]
    int jumpThreshold;

    bool jump = false;

    Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if(!jump && Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    //called the same amount of times as the frame rate (ex: 60fps - 60 calls per second)
    private void FixedUpdate()
    {
        movement.x = horizontalInput * movementSpeed * Time.deltaTime;

        //player not grounded? let gravity pull it down
        //the else statement here is to fix up the fall rate so that it's exponential
        if (!characterController.isGrounded)
        {
            if(movement.y > 0)
            {
                movement.y -= gravity;
            }
            else
            {
                movement.y -= gravity * 1.5f;
            }
        }
        else
        {
            //once the player is grounded, stop the gravity on the player and reset the jump counter
            movement.y = 0;
            jumpCount = 0;
        }

        //true whenever 'jump' key is pressed down
        //only allow to jump to the threshold amount
        if (jump && jumpCount < jumpThreshold)
        {
            movement.y = jumpHeight;
            jump = false;
            jumpCount++;
        }

        if (characterController)
        {
            //check that the charactar controller has been setup properly
            //Move the charactar in x and y directions based on the input 
            characterController.Move(movement);
        }      
    }
}
