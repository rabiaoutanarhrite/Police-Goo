using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Countdown : MonoBehaviour
{
    public float timeStart = 60;
    public TextMeshProUGUI countDown;

     public void Start()
    {
        countDown.text = timeStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timeStart -= Time.deltaTime;

        for (float i = 0; i <= timeStart; i++)
        {
            countDown.text = Mathf.Round(timeStart).ToString();
            Debug.Log(countDown.text);

            if (countDown.text == "0")
            {
                GameManager.instance.gameOver.SetActive(true);


                GameManager.instance.playerCar.GetComponent<Car>().enabled = false;
            }


        }
    }

    public void starTime()
    {
        
    }
}
