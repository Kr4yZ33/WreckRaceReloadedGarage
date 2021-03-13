using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutsideVisible : MonoBehaviour
{
    public GameObject outsideTrack;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            outsideTrack.SetActive(true);
        }
    }
}
