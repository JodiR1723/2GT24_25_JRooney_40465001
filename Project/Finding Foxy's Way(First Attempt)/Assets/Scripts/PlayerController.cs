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
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool hasPowerup;
    public Animator anim; 

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    
    }

    // Update is called once per frame
    void Update()
    {
        //Player Inputs 
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Moving the player
        float verticalAxis = Input.GetAxis("Vertical");
        float horizontalAxis = Input.GetAxis("Horizontal");

        playerRb.velocity = transform.forward * speed * forwardInput + transform.up * playerRb.velocity.y;
        this.anim.SetFloat("vertical", verticalAxis);
        this.anim.SetFloat("horizontal", horizontalAxis);

        //Turning the player
        transform.Rotate(Vector3.up* Time.deltaTime * turnSpeed * horizontalInput);
        //Making the player jump
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            this.anim.SetBool("jump", true);
        }
        else
        {
            this.anim.SetBool("jump", false);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {
            hasPowerup = true;
            Destroy(other.gameObject);
        }
    }
}
