using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraNewPosition : MonoBehaviour
{
    public GameObject cinMachineCam;

    // CinemachineComposer composer;
    public float Speed = 0.01f;

    public Vector3 newOffset;

    private bool isOn = false;

    private void LateUpdate()
    {
        if(isOn)
        {
            CinemachineVirtualCamera vcam = cinMachineCam.GetComponent<Cinemachine.CinemachineVirtualCamera>();
            CinemachineTransposer transposer = vcam.GetCinemachineComponent<CinemachineTransposer>();
            
            transposer.m_FollowOffset = Vector3.Lerp(transposer.m_FollowOffset, newOffset, transposer.m_YawDamping * Time.deltaTime);
            StartCoroutine(exitFunc());

        }

      
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isOn = true;
            
        }
    }

    IEnumerator exitFunc()
    {
        yield return new WaitForSeconds(2.1f);

        isOn = false;
    }

    
}
