using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotObj : MonoBehaviour
{
    //public GameObject playerCar;
    //public GameObject car;
    public GameObject explosionVFX;


    void Start()
    {
        
            }

    private void OnTriggerEnter(Collider other)
    {
       
        

        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.instance.playerCar.GetComponent<Car>().enabled = false;
            GameManager.instance.stopTime();
            Debug.Log("Done!");
            

            GameManager.instance.explosionVFX.SetActive(true);
            GameManager.instance.gameOver.SetActive(true);
            GameManager.instance.firstCam.GetComponent<CinemachineBrain>().enabled = false;
            Vibrations.Vibrate(1000);


            GameObject carobject;
            carobject = GameObject.FindWithTag("Car");
            Destroy(carobject);


            



        }

       
    }
}
