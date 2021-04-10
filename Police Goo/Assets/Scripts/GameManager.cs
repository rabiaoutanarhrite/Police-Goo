using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public float time = 60;
    public TextMeshProUGUI countDown;
    public GameObject levelProgress;
    public GameObject youWin;
    public GameObject gameOver;

    public int startCount;
    public TextMeshProUGUI starttext;

    [HideInInspector] public GameObject playerCar;
    [HideInInspector] public GameObject explosionVFX;
    public GameObject firstCam;

    public GameObject touchImg;

    public GameObject coinsVFX;
    public GameObject coins;

    public GameObject fixedTouchField;

    public GameObject pauseBtn;

    public Slider audioSlider;
    /*public Text currentCoins;
    public static int iniCoins;


    public Text coinsUI;
    private static int coins;*/


    private void Awake()
    {
        instance = this;

        
    }

    void Start()
    {
        // currentCoins.text = PlayerPrefs.GetInt("CurrentCoins" , iniCoins).ToString();

        
        countDown.enabled = false;
        //countDown.text = timeStart.ToString();
        StartCoroutine(Go());
        StartCoroutine(StartGame());

        playerCar = GameObject.FindGameObjectWithTag("Player");
        explosionVFX = GameObject.Find("Explosion");
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.L))
        {
            PlayerPrefs.DeleteAll();
            PlayerPrefs.Save();
        }


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

            if (time <= 10)
            {
                countDown.color = Color.red;
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

        starttext.text = "GO";
        Vibrations.Vibrate(1000);
        

        StartCoroutine(Touch());

        yield return new WaitForSeconds(1f);

        countDown.enabled = true;
        starttext.enabled = false;
        levelProgress.SetActive(true);
        starTime();
        playerCar.GetComponent<AudioSource>().enabled = true;
        playerCar.GetComponent<Car>().enabled = true;

        
    }

    IEnumerator Touch()
    {
        touchImg.SetActive(true);
        yield return new WaitForSeconds(2f);
        touchImg.SetActive(false);

    }

    IEnumerator StartGame()
    {
        
        yield return new WaitForSeconds(1f);
        starttext.GetComponent<AudioSource>().enabled = true;
        starttext.color = Color.yellow;
        yield return new WaitForSeconds(1f);
        starttext.color = Color.green;
        yield return new WaitForSeconds(1f);
        starttext.color = Color.blue;
        yield return new WaitForSeconds(1f);
        starttext.color = Color.red;

       
    }

 


}
