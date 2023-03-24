using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawnControl : MonoBehaviour
{
    public GameObject fish; //Array to store UFO ships (shows up in unity)
    private float spawnRangeX = 11f;
    private float spawnPosZ = 0f;
    private float startDelay = 2f;
    private float spawnInterval = 2.5f;


    // Start is called before the first frame update
    void Start()
    {
        //name, how long is it gonna take before invokerepeat starts, and delay between spawns
        InvokeRepeating("spawnFish", startDelay, spawnInterval);
    }

    

    void spawnFish()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0,spawnPosZ);
        
        
        Instantiate(fish,spawnPos,fish.transform.rotation); 
        
    }
}
