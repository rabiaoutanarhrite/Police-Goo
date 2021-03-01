using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoScript : MonoBehaviour
{
    private float speed = 10000;
    public Car car;
    
    private void OnTriggerEnter(Collider other)
    {


        //car.addSpeed();
        //  Debug.Log("done!!!!!");
        Destroy(other.gameObject);

    }
}