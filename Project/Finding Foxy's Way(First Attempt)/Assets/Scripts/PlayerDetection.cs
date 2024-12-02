using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerDetection : MonoBehaviour
{
    // Variables
    public GameObject objectToMove;
    private bool playerInArea = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnCollisionEnter(Collision collision)
    {
        //Check if player has entered the trigger zone 

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInArea = true;
            
            if (objectToMove != null)
            {
                objectToMove.GetComponent<ObjectMovement>().StartMoving();
            }
        }

    }
}
