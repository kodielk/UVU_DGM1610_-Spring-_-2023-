using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); //Destroy this game object
        Destroy(other.gameObject); // Destroy the other game object it hits
    }
}
