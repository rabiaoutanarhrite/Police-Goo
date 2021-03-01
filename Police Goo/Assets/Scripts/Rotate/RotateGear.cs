using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RotateGear : MonoBehaviour
{
    public float speed = 20f;
    public bool rotX;
    public bool rotY;
    public bool rotZ;


 

    void Update()
    {

        if(rotX == true)
        {
            transform.Rotate( speed * Time.deltaTime, 0, 0);
        }

        if (rotY == true)
        {
            transform.Rotate( 0, speed * Time.deltaTime, 0);
        }
        
        if (rotZ == true)
        {
            transform.Rotate( 0, 0 , speed * Time.deltaTime);
        }

    }
}
