using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelector : MonoBehaviour
{
    public static CarSelector instance;
     
    public static GameObject target;

    public int currentCarIndex = 0;
    public GameObject[] cars;

    private void Awake()
    {
        instance = this;

        currentCarIndex = PlayerPrefs.GetInt("SelectorCar", 0);

        foreach (GameObject car in cars)
        {
            car.SetActive(false);
        }

        cars[currentCarIndex].SetActive(true);
        target = cars[currentCarIndex];
    }

    void Start()
    {
        
      }



}
