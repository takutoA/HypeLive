using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoshManager : MonoBehaviour
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

        if (Time.time < 6.2)
        {
            //transform.position = Vector3.Lerp(startPosition, targetPosition, interpolatedValue);
        }
        else if (6.2 <= Time.time && Time.time <= 89)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, interpolatedValue);
        }
        else if (89 <= Time.time && Time.time <= 135)
        {
            transform.position = Vector3.Lerp(transform.position, startPosition, interpolatedValue);
        }
        else if (135 <= Time.time && Time.time <= 162)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, interpolatedValue);
        }
        else if (162 <= Time.time && Time.time <= 193)
        {
            transform.position = Vector3.Lerp(transform.position, startPosition, interpolatedValue);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, interpolatedValue);
        }
    }
}
