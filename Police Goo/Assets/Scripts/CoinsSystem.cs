using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoinsSystem : MonoBehaviour
{
   

    public Text currentCoins;
    public static int iniCoins;


    public Text coinsUI;
    private static int coins;

    void Start()
    {
        currentCoins.text = PlayerPrefs.GetInt("CurrentCoins", iniCoins).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(coins);
    }

    public void EarnCoins()
    {
        float time = GameManager.instance.time;
        if (time > 5)
        {
            coins = 150;
            iniCoins = iniCoins + coins;
            coinsUI.text = ("+" + coins.ToString() + "$");

        }

        else if (time <= 5 && time >= 3)
        {
            coins = 100;
            iniCoins = iniCoins + coins;
            coinsUI.text = ("+" + coins.ToString() + "$");

        }

        else if (time < 3 && time > 0)
        {
            coins = 50;
            iniCoins = iniCoins + coins;
            coinsUI.text = ("+" + coins.ToString() + "$");

        }

        else if (time == 0)
        {
            coins = 0;
            iniCoins = iniCoins + coins;
            coinsUI.text = ("+" + coins.ToString() + "$");

        }

        PlayerPrefs.SetInt("CurrentCoins", iniCoins / 2);
        PlayerPrefs.Save();
        currentCoins.text = (iniCoins / 2).ToString();

    }
}
