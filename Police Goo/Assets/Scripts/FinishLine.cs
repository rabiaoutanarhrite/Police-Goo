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
           

            other.GetComponentInChildren<Rigidbody>().isKinematic = true;
            other.GetComponent<AudioSource>().enabled = false;
            other.GetComponent<Car>().enabled = false;
            Debug.Log("You Win!!");
            winVFX.SetActive(true);
            StartCoroutine(Winning());

            Vibrations.Vibrate(1500);


        }


    }

  
    
    IEnumerator Winning()
    {
        yield return new WaitForSeconds(2); 
        winPanel.SetActive(true);
        yield return new WaitForSeconds(1);
        GameManager.instance.coinsVFX.SetActive(true);
        GameManager.instance.coins.GetComponent<CoinsSystem>().EarnCoins();
    }
    
    
}
