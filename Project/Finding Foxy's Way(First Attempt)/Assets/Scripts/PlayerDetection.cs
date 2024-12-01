using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetection : MonoBehaviour
{
    // Variables
    private bool shouldMove = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //Check if player has entered the trigger zone
        if (other.CompareTag("Player"))
        {
            shouldMove = true;
        }
    }
}
