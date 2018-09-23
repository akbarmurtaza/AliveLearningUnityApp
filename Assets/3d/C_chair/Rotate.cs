

using UnityEngine;
using System.Collections;

// Makes objects float up & down while gently spinning.
public class Rotate : MonoBehaviour
{
   
public void Start()
{
StartCoroutine("Rotate90");
}

public IEnumerator Rotate90()
{
Vector3 axis = Vector3.up;
float angle = 90.0f;
float rotAmount = 0.0f;

Quaternion startingRot = transform.rotation;

while (rotAmount < angle)
{
rotAmount = Mathf.SmoothStep(0.0f, angle, Time.deltaTime);
transform.RotateAround(axis, rotAmount);
yield return 0;
}
}
}
