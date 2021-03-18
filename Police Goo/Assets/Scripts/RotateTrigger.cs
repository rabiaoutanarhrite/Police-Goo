using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTrigger : MonoBehaviour
{
    public float rotationDir = 90;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.Rotate(transform.up * rotationDir);
            Destroy(gameObject);
        }
    }
}
