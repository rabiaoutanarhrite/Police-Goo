using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopManager : MonoBehaviour
{
    public int currentCarIndex = 0;
    public GameObject[] carModels;

    public CarBleuprint[] cars;
    public Button buyBtn;
    public GameObject lockImg;
    public Text priceText;

    void Start()
    {

        foreach(CarBleuprint car in cars )
        {
            if (car.price == 0)
            {
                car.isUnlocked = true;
            }
            else
            {
                car.isUnlocked = PlayerPrefs.GetInt(car.name, 0)  == 0 ? false: true;

            }
        }


        currentCarIndex = PlayerPrefs.GetInt("SelectorCar", 0); 

        foreach(GameObject car in carModels)
        {
            car.SetActive(false);
        }

        carModels[currentCarIndex].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        UpdateUI();
    }

    public void NextCar()
    {
        carModels[currentCarIndex].SetActive(false);

        currentCarIndex++;
        if(currentCarIndex == carModels.Length)
        { 
            currentCarIndex = 0;
        }

        carModels[currentCarIndex].SetActive(true);
        CarBleuprint c = cars[currentCarIndex];
        if (!c.isUnlocked)
            return;

        PlayerPrefs.SetInt("SelectorCar", currentCarIndex);


    }

    public void PreviousCar()
    {
        carModels[currentCarIndex].SetActive(false);

        currentCarIndex--;
        if (currentCarIndex == -1)
        {
            currentCarIndex = carModels.Length -1;
        }

        carModels[currentCarIndex].SetActive(true);
        CarBleuprint c = cars[currentCarIndex];
        if (!c.isUnlocked)
            return;

        PlayerPrefs.SetInt("SelectorCar", currentCarIndex);

 
    }

    public void BuyCar()
    {
        
        CarBleuprint c = cars[currentCarIndex];
        if (!c.isUnlocked)
        {
            PlayerPrefs.SetInt(c.name, 1);
            PlayerPrefs.SetInt("SelectorCar", currentCarIndex);
            c.isUnlocked = true;
            PlayerPrefs.SetInt("CurrentCoins", PlayerPrefs.GetInt("CurrentCoins", 0) - c.price);
            MainMenu.instance.PlayGame();
        }
        else
        {
            MainMenu.instance.PlayGame();
        }
        
    }

    private void UpdateUI()
    {
        CarBleuprint c = cars[currentCarIndex];
        if(c.isUnlocked)
        {
            priceText.text = c.price + " $";
            buyBtn.interactable = true;
            lockImg.SetActive(false);
        }
        else
        {
            lockImg.SetActive(true);
            buyBtn.gameObject.SetActive(true);
            priceText.text = c.price + " $";
            if(c.price <= PlayerPrefs.GetInt("CurrentCoins", 0))
            {
                buyBtn.interactable = true;
                
            }
            

            else
            {
                buyBtn.interactable = false;
               
            }
        }
    }


}
