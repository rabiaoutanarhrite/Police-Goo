using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public static Car selectedPlayer;


    private Rigidbody body;
    public float speed;

    //public GameObject explosionVFX;

    void Start()
    {
        //explosionVFX.SetActive(false);
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

    public void ExplosionFX()
    {
        //explosionVFX.SetActive(true);
    }
}
