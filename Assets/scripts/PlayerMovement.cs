using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;


    // Update is called once per frame
    void Update()
    {
       horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

       if (Input.GetButtonDown("Jump"))
       {
            jump = true;
       }

    }


    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        //poruszanie sie postaci ig
        jump = false;
        //a to wyzej jest do skoku to nvm
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin")
        {
            ScoreManager.scoreCount += 1;
        }
    }
}
