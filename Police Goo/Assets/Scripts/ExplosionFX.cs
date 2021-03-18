using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionFX : MonoBehaviour
{
    public GameObject expVFX;

    Rigidbody body;

    private void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (GameManager.instance.time == 0)
        {
            body.constraints = RigidbodyConstraints.FreezeAll;
        }
    }

    public void ExpVFX()
    {
        expVFX.SetActive(true);
    }
}
