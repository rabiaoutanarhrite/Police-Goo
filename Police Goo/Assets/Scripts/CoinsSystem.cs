using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoinsSystem : MonoBehaviour
{
   

    public Text currentCoins;
    public static int iniCoins = 0;


    public Text coinsUI;
    private  int coins;

   

    void Start()
    {
        iniCoins = PlayerPrefs.GetInt("CurrentCoins", iniCoins);
        currentCoins.text = iniCoins.ToString();
    }

    void Update()
    {
        PlayerPrefs.Save();
    }

    public void EarnCoins()
    {
       
        float time = GameManager.instance.time;
        if (time > 5)
        {
            coins = 150;
            //iniCoins = iniCoins + coins;
            coinsUI.text = ("+" + coins.ToString() + "$");
            currentCoins.text = (iniCoins/2).ToString();
        }

        else if (time <= 5 && time >= 3)
        {
            coins = 100;
           // iniCoins += coins;
            coinsUI.text = ("+" + coins.ToString() + "$");
            currentCoins.text = (iniCoins / 2).ToString();
        }

        else if (time < 3 && time > 0)
        {
            coins = 50;
            //iniCoins += coins;
            coinsUI.text = ("+" + coins.ToString() + "$");
            currentCoins.text = (iniCoins / 2).ToString();
        }

        else if (time == 0)
        {
            coins = 0;
            //iniCoins += coins;
            coinsUI.text = ("+" + coins.ToString() + "$");
            currentCoins.text = (iniCoins / 2).ToString();
        }
        

        PlayerPrefs.SetInt("CurrentCoins", iniCoins + coins);
        currentCoins.text = (iniCoins + coins).ToString();


    }

    public void ExtraCoin()
    {
        coins = 10;
        iniCoins += coins;
        PlayerPrefs.SetInt("CurrentCoins", iniCoins);
       
        currentCoins.text = iniCoins.ToString();
       
    }

    

}
