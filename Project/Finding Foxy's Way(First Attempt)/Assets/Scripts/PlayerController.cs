using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variables
    private float speed = 12.0f;
    private float turnSpeed = 80.0f;
    private float horizontalInput;
    private float forwardInput;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Player Inputs 
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Moving the player foward 
        transform.Translate(transform.forward * Time.deltaTime * speed * forwardInput);
        //Turning the player
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
