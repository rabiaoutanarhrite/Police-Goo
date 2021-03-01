using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody body;
    public float speed;
    public float rotationSpeed;

    void Start()
    {
        body = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        if (Input.GetAxis("Fire1") > 0f)
        {
            body.velocity = transform.forward * speed * Time.fixedDeltaTime;
        }
    }
}
