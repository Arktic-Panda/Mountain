using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController control;
    public Transform groundcheck;
    public LayerMask groundMask;
    
    public float speed = 10f;
    public float gravity = 9.81f;
    public float groundDistance = 0.4f;
    public float jumpHeight = 10f;

    Vector3 velocity;
    bool isGrounded;


    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundcheck.position, groundDistance, groundMask);


        if(isGrounded && velocity.y<0 )
        {
            velocity.y = -2f;
           
        }

        float horizontal = Input.GetAxis("Horizontal");
        float frontal     = Input.GetAxis("Vertical");

        Vector3 move = (transform.right * horizontal) + (transform.forward * frontal);

        control.Move(move * speed * Time.deltaTime);
        velocity.y -= gravity * Time.deltaTime;
        control.Move(velocity * Time.deltaTime);

        
         if( Input.GetKeyDown("space") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight  * gravity);
            
        }

    }
}
