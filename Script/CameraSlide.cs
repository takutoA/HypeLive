using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSlide : MonoBehaviour
{
    public GameObject target1, target2, target3;
    void Start()
    {
        StartCoroutine(LerpFunction1(target1.transform.position, Quaternion.Euler(target1.transform.eulerAngles), 5));
    }

    void Update()
    {

    }

    IEnumerator LerpFunction1(Vector3 endValuePos, Quaternion endValueRot, float duration)
    {
        float time = 0;
        Vector3 startValuePos = transform.position;
        Quaternion startValueRot = transform.rotation;

        while (time < duration)
        {
            transform.position = Vector3.Lerp(startValuePos, endValuePos, time / duration);
            transform.rotation = Quaternion.Lerp(startValueRot, endValueRot, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.position = endValuePos;
        transform.rotation = endValueRot;
        yield return StartCoroutine(LerpFunction2(target2.transform.position, Quaternion.Euler(target2.transform.eulerAngles), 10));
    }
    IEnumerator LerpFunction2(Vector3 endValuePos, Quaternion endValueRot, float duration)
    {
        float time = 0;
        Vector3 startValuePos = transform.position;
        Quaternion startValueRot = transform.rotation;

        while (time < duration)
        {
            transform.position = Vector3.Lerp(startValuePos, endValuePos, time / duration);
            transform.rotation = Quaternion.Lerp(startValueRot, endValueRot, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.position = endValuePos;
        transform.rotation = endValueRot;
        yield return StartCoroutine(LerpFunction3(target3.transform.position, Quaternion.Euler(target3.transform.eulerAngles), 10));
    }
    IEnumerator LerpFunction3(Vector3 endValuePos, Quaternion endValueRot, float duration)
    {
        float time = 0;
        Vector3 startValuePos = transform.position;
        Quaternion startValueRot = transform.rotation;

        while (time < duration)
        {
            transform.position = Vector3.Lerp(startValuePos, endValuePos, time / duration);
            transform.rotation = Quaternion.Lerp(startValueRot, endValueRot, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.position = endValuePos;
        transform.rotation = endValueRot;
        yield return StartCoroutine(LerpFunction1(target1.transform.position, Quaternion.Euler(target1.transform.eulerAngles), 10));
    }
}
