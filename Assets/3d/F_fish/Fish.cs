using UnityEngine;
using System;
using System.Collections;

public class Fish : MonoBehaviour
{
    float originalY;

    public float floatStrength = 8; // You can change this in the Unity Editor to 
                                    // change the range of y positions that are possible.

    void Start()
    {
        this.originalY = this.transform.position.x;
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.y,
            originalY + ((float)Math.Sin(Time.time) * floatStrength),
            transform.position.x);
    }
}