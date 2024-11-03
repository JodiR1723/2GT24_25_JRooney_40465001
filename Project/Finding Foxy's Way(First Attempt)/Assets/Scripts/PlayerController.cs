using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variables
    public float speed = 7.0f;
    public float turnSpeed = 40.0f;
    public float horizontalInput;
    public float forwardInput;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Player Inputs 
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Moving the veichle foward 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Turning the veichle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
