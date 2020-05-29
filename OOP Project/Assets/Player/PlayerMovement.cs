using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D Controller;
    float horizontalmove = 0f;
    public float RunSpeed = 50f;
    bool jump = false;

    // Update is called once per frame
    void Update()
    {
        horizontalmove = Input.GetAxisRaw("Horizontal") * RunSpeed;

        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        else if (Input.GetButtonUp("Jump"))
        {
            jump = false;
        }
    }

    void FixedUpdate()
    {
        Controller.Move(horizontalmove * Time.fixedDeltaTime, false, jump);
    }
}
