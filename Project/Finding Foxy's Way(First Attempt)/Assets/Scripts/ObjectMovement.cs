using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    // Variables
    public Transform player;
    public float moveSpeed = 5f;
    public Vector3 moveDirection = Vector3.forward;

    private bool shouldMove = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldMove)
        {
            //Moving the object infront of the player
            Vector3 targetPosition = player.position + moveDirection * 5f;
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }
    }
   
}
