using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheels : MonoBehaviour
{
    public float rotSpeed;

    void Update()
    {
        if(Input.GetAxis("Fire1") > 0f)
        {

            transform.Rotate(rotSpeed * Time.deltaTime, 0, 0);
        }
    }
}
