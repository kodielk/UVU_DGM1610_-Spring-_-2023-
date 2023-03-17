using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    public float xRange;
    public Transform chest;
    public GameObject coin;
   
    
   
    // Update is called once per frame
    void Update()
    {
        // Set HorizontalInput to get values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");
        
        //moves the guy l and r
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        
        //keeps guy in bounds (left side wall)
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        
        //(right side wall)
        if (transform.position.x > xRange) 
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        //space bar produces coin
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //creates coin at chest position
            Instantiate(coin, chest.transform.position, coin.transform.rotation);
        }

    }
    //Delete any object with a trigger that hits the player
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        

    }
    
}
