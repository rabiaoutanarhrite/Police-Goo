using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraNewPosition : MonoBehaviour
{
    public GameObject cinMachineCam;

    // CinemachineComposer composer;
    public float Speed = 0.01f;
    private bool isOn = false;
    public Vector3 newOffset;
    public bool TrackOn = false;
    public Vector3 newTrackOffset;

    

    

    private void FixedUpdate()
    {
        if(isOn)
        {
            CinemachineVirtualCamera vcam = cinMachineCam.GetComponent<Cinemachine.CinemachineVirtualCamera>();
            CinemachineTransposer transposer = vcam.GetCinemachineComponent<CinemachineTransposer>();
            
            transposer.m_FollowOffset = Vector3.Lerp(transposer.m_FollowOffset, newOffset, transposer.m_YawDamping * Time.fixedDeltaTime);

            if (TrackOn)
            {
                CinemachineComposer composer = vcam.GetCinemachineComponent<CinemachineComposer>();

                composer.m_TrackedObjectOffset = newTrackOffset;
            }

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
