using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarHolder : MonoBehaviour
{
    public float rotCarsSpeed = 50;

    private void Update()
    {
        transform.Rotate(0f, rotCarsSpeed * Time.deltaTime, 0f);
    }
}
