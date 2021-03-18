using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotObj : MonoBehaviour
{
    //public GameObject playerCar;
    //public GameObject car;
   


    void Start()
    {
        
            }

    private void OnTriggerEnter(Collider other)
    {
       
        

        if (other.gameObject.CompareTag("Player"))
        {
            //other.gameObject.GetComponent<Car>().enabled = false;
            other.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            //other.gameObject.GetComponent<Car>().ExplosionFX();
            other.gameObject.GetComponent<ExplosionFX>().ExpVFX();
            other.gameObject.GetComponent<AudioSource>().enabled = false;
            GameManager.instance.stopTime();
            Debug.Log("Done!");
            

            GameManager.instance.gameOver.SetActive(true);
            
            Vibrations.Vibrate(500);


            GameObject carobject;
            carobject = GameObject.FindWithTag("Car");
            Destroy(carobject);


            



        }

       
    }
}
