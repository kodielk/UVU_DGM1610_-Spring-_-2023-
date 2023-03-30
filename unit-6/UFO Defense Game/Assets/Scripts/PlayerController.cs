using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    public float xRange;
    public Transform blaster;
    public GameObject laserBolt;
    public AudioSource clip;
    public GameManager gameManager;


    void Start()
    {
        //                            GameObject                   Script Component 
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); //Reference GameManager Script on GameManager object
    }

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
        //space bar press fire bolt
        if (Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false) // Second Condition gameManager.isGameOver prevents the player from shooting after isGameOver becomes true
        {
            clip.Play(); //plays laser sound
            //creates laser bolt @ blaster position
            Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);
        }
    }
    //Delete any object with a trigger that hits the player
    private void OnTriggerEnter(Collider other)
    {
        gameManager.isGameOver = true;
        Destroy(other.gameObject);
        Time.timeScale = 0;

    }
}
