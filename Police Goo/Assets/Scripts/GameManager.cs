using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public float time = 60;
    public TextMeshProUGUI countDown;
    public GameObject gameOver;

    public int startCount;
    public TextMeshProUGUI starttext;

    public GameObject playerCar;
    public GameObject explosionVFX;
    public GameObject firstCam;
    public GameObject lastCam;

    public GameObject touchImg;


    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        countDown.enabled = false;
        //countDown.text = timeStart.ToString();
        StartCoroutine(Go());
    }

    // Update is called once per frame
    void Update()
    {

        

        // if th player lose the game
       

        
    }

    public void starTime()
    {


        InvokeRepeating("IncrimentTime", 1, 1);
        if (time == 0)
        {
            gameOver.SetActive(true);
            Vibrations.Vibrate(1000);

        }

    }

    public void stopTime()
    {
        CancelInvoke();
    }

    void IncrimentTime()
    {
        time -= 1;  
        
        for (int i = 0; i <= time; i++)
        {
            countDown.text = time.ToString();
            
            if (countDown.text == "0")
            {
                gameOver.SetActive(true);
                playerCar.GetComponent<Car>().enabled = false;
            }
        }      
    }

    IEnumerator Go()
    {
        yield return new WaitForSeconds(1f);

        while (startCount > 0)
        {
            starttext.text = startCount.ToString();

            yield return new WaitForSeconds(1f);

            startCount--;

        }

        starttext.text = "Go !";
        Vibrations.Vibrate(1000);

        StartCoroutine(Touch());

        yield return new WaitForSeconds(1f);
        countDown.enabled = true;
        starttext.enabled = false;

        playerCar.GetComponent<Car>().enabled = true;

        starTime();
    }

    IEnumerator Touch()
    {
        touchImg.SetActive(true);
        yield return new WaitForSeconds(2f);
        touchImg.SetActive(false);

    }


}
