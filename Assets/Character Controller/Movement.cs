using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController controller;
    public float gravity = -9.86f;
    public float speed = 12f;
    public float jmpheight = 5f;

    Vector3 velocity;
    bool isGrounded;

    public Transform GroundCheck;
    public float GroundDistance = 0.4f;
    public LayerMask groundMask;

    void Update()
    {
        isGrounded = Physics.CheckSphere(GroundCheck.position, GroundDistance , groundMask);
        if (isGrounded && velocity.y < 0){
                velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");

        float y = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x  + transform.forward * y;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump")){
            velocity.y = Mathf.Sqrt(jmpheight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime; //to build up velocity

        controller.Move(velocity * Time.deltaTime); //time multiplied twice since delta y=1/2g*t^2

    }
}
