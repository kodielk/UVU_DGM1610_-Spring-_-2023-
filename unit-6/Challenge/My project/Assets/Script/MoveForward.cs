using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 10.0f;
    // Update is called once per frame
    void Update()
    {
        //Move GameObject forward
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
}
