using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheels : MonoBehaviour
{
    public float rotSpeed;

    void Update()
    {
        if(GameManager.instance.fixedTouchField.GetComponent<FixedTouchField>().Pressed)
        {

            transform.Rotate(rotSpeed * Time.deltaTime, 0, 0);
        }
    }
}
