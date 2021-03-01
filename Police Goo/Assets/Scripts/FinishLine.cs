using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameObject winVFX;
    public GameObject winPanel;
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.instance.stopTime();
            GameManager.instance.firstCam.SetActive(false);
            GameManager.instance.lastCam.GetComponent<CamRot>().enabled = true;
            GameManager.instance.playerCar.GetComponentInChildren<Rigidbody>().isKinematic = true;
            GameManager.instance.playerCar.GetComponent<Car>().enabled = false;
            Debug.Log("You Win!!");
            winVFX.SetActive(true);
            StartCoroutine(Winning());

            Vibrations.Vibrate(1500);


            //Destroy(GameManager.instance.gameOver);
            //GameManager.instance.gameOver.SetActive(false);



        }


    }

    IEnumerator Winning()
    {
        yield return new WaitForSeconds(2);
        winPanel.SetActive(true);
    }
    
    
}
