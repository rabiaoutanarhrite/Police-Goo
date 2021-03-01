using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gantra : MonoBehaviour
{
    
    public float speed;

    public void Update()
    {
        float x = Mathf.PingPong(Time.deltaTime* speed, 3.9f) ;
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }


}
