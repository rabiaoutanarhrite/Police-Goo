using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowCar : MonoBehaviour
{
    public List<GameObject> targetTrans;
   
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private void Start()
    {
        
    }
    

    private void LateUpdate()
    {
        foreach(GameObject target in targetTrans)
        {
            if(target.activeSelf == true)
            {
                Transform carObj = target.GetComponent<Transform>();
                Vector3 desiredPos = carObj.position + offset;
                Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed * Time.deltaTime);
                transform.position = smoothedPos;

                
                transform.LookAt(carObj.position);


            }
        }

        
    }
}
