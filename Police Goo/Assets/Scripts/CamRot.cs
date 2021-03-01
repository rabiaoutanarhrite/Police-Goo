using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CamRot : MonoBehaviour
{
    public float Speed;

    void Update()
    {
        StartCoroutine(rotDuration());
    }

    IEnumerator rotDuration()
    {
        transform.Rotate(0, Speed * Time.deltaTime, 0);
        yield return new WaitForSeconds(3);
        Speed = 0;
        transform.Rotate(0, Speed * Time.deltaTime, 0);
    }

 
}
