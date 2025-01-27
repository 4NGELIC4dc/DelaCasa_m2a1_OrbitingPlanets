using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpInterpolation : MonoBehaviour
{
    private Vector3 pointA;
    private Vector3 pointB = new Vector3(x: 5, y: -5, z: 0);
    private float minValue = 0;
    private float maxValue = 5;
    private float desiredDuration = 3f;

    private float elapsedTime;
    private void Start()
    {
        pointA = transform.position;   
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.L))
        {
            elapsedTime += Time.deltaTime;
            float t = elapsedTime / desiredDuration;

            transform.position = Vector3.Lerp(pointA, pointB, t);
        }
        
        if (Input.GetKey(KeyCode.C))
        {
            elapsedTime += Time.deltaTime;
            elapsedTime = Mathf.Clamp(elapsedTime, minValue, maxValue);

            Debug.Log(message: $"Clamped Value {elapsedTime}");
        }

        if (Input.GetKey(KeyCode.R)) {
            elapsedTime = 0;
            transform.position = pointA;
        }
    }
}
