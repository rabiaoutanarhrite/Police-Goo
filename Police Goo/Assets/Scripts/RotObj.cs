using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotObj : MonoBehaviour
{
    public bool levelCompleted = false;

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
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
            GameManager.instance.stopTime();
            if (levelCompleted)
            {
                GameManager.instance.youWin.SetActive(true);
            }
            else
            {
                GameManager.instance.gameOver.SetActive(true);
            }
            GameManager.instance.pauseBtn.SetActive(false);
            
            
            Vibrations.Vibrate(500);


            GameObject carobject;
            carobject = GameObject.FindWithTag("Car");
            carobject.SetActive(false);

            this.GetComponent<Collider>().enabled = false;

            



        }

       
    }
}
