using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{
    public float speed = 250.0f;
    private Vector3 rotate = new Vector3(0,0,1);
    void Update()
    {
        transform.Rotate(rotate, speed * Time.deltaTime);
    }
}
