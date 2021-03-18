using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTargetCin : MonoBehaviour
{
    public List<GameObject> targetTrans;

    private GameObject camTrans;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject target in targetTrans)
        {
            if (target.activeSelf == true)
            {
                Transform carObj = target.GetComponent<Transform>();
                
                this.GetComponent<Cinemachine.CinemachineVirtualCamera>().Follow = carObj;
                this.GetComponent<Cinemachine.CinemachineVirtualCamera>().LookAt = carObj;


            }
        }

    }
}
