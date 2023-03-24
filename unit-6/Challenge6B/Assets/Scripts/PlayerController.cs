using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;

    public float speed;

    public float xRange;
    // Update is called once per frame
    void Update()
    {
        //key input set
        horizontalInput = Input.GetAxis("Horizontal");
        
        //left and right movement
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        
        //boundaries (left, then right)
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

    }
    
    //deletes any object with a trigger that hits the player
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
