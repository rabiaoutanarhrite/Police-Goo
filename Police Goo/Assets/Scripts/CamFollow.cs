using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{

    public Transform target; // Player Transform Setting
   // public float Speed;

    public float smoothSpeed = 0.125f; 
    public Vector3 offset; // Giving the new postion to the camera


    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset; // the value of the new postion
        Vector3 smothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // smoth the camera
        transform.position = smothedPosition;

        transform.LookAt(target);

    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Enemy")
        {
            Debug.Log("You Lose!");
            print("fuck");
        }
    }



}
