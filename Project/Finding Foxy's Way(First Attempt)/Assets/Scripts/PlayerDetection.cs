using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;

public class PlayerDetection : MonoBehaviour
{
    // Variables
    public TextMeshProUGUI finishedText;

    void Start()
    {
        // Finished text is hidden at the start
        finishedText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    // Finish message is triggered when the player collides with the home object
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Finish")) // Assuming the tag of the target object is "FinishLine"
        {
            // Show the "Finished" text
            finishedText.gameObject.SetActive(true);

            // Pause the game 
            Time.timeScale = 0f;
        }
    }
    
}
