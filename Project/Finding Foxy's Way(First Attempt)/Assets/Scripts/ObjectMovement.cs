using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    // Variables
    public float speed = 5f;
    private bool isMoving = false;

    public void StartMoving()
    {
        //Start moving the object
        isMoving = true;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
   
}
