using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{

    public GameObject[] ufoPrefabs; //Array to store UFO ships (shows up in unity)
    private float spawnRangeX = 20f;
    private float spawnPosZ = 20f;
    private float startDelay = 2f;
    private float spawnInterval = 2.5f;


    // Start is called before the first frame update
    void Start()
    {
        //name, how long is it gonna take before invokerepeat starts, and delay between spawns
        InvokeRepeating("SpawnRandomUfo", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomUfo()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0,spawnPosZ);
        //random ufo spawn from array
        int ufoIndex = Random.Range(0,ufoPrefabs.Length);
        
        //what are u makin (from ufoIndex)->position where it spawn?->technowechno stuff (rotation?)
        Instantiate(ufoPrefabs[ufoIndex],spawnPos, ufoPrefabs[ufoIndex].transform.rotation); //Spawns an indexed UFO from the array a random location on the X-Axis
        
    }
}
