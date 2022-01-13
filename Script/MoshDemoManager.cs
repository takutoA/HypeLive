using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoshDemoManager : MonoBehaviour
{
    private float startTime, distance;
    private Vector3 startPosition;
    [SerializeField]
    private Vector3 targetPosition;
    [SerializeField, Range(0f, 1f)]
    private float interpolatedValue;

    void Start()
    {
        startTime = Time.time;
        startPosition = transform.position;
    }

    void Update()
    {

        if (Time.time < 8)
        {
            //transform.position = Vector3.Lerp(startPosition, targetPosition, interpolatedValue);
        }
        else if (8 <= Time.time && Time.time <= 36)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, interpolatedValue);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, startPosition, interpolatedValue);
        }
    }
}
