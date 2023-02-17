using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sova : MonoBehaviour
{
    public string openingVoice;
    public float arrowDmg;
    // Use this for initialization
    void Start () 
    {
        Debug.Log(openingVoice);
        Debug.Log("Sova's arrow damage is " + arrowDmg);
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Sova shoots his arrow, doing " + arrowDmg +" damage.");
        }
    }   

}
