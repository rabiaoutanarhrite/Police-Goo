using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Car : MonoBehaviour
{
    private Rigidbody body;
    public float speed;

    

    void Start()
    {
        body = GetComponent<Rigidbody>();
       
    }
    void FixedUpdate()
    {
        if (Input.GetAxis("Fire1") > 0f)
        {
            body.velocity = transform.forward * speed * Time.fixedDeltaTime;
            body.isKinematic = false;
        }
        else
        {
            body.isKinematic = true;
        }
       
    }
}
