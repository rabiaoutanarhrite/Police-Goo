using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CoinsCollection : MonoBehaviour
{
    public CoinsSystem coinIni;
    public GameObject vfxCoin;

    public static int extCoin = 10;

    MeshRenderer coinMesh;
    MeshCollider coinCollider;
    AudioSource coinSound;

    private void Start()
    {
        coinSound = GetComponentInChildren<AudioSource>();
        coinMesh = GetComponentInChildren<MeshRenderer>();
        coinCollider = GetComponent<MeshCollider>();
    }


    public void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
            
            coinIni.ExtraCoin();
            coinSound.enabled = true;
            coinMesh.enabled = false;
            vfxCoin.SetActive(false);
            coinCollider.enabled = false;

        }
    }


     
}
