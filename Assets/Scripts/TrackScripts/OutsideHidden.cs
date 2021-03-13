using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutsideHidden : MonoBehaviour
{
    public GameObject outsideTrack;
    bool outsideTrackVisible = true;

    void FixedUpdate()
    {
        if(!outsideTrackVisible)
        {
            outsideTrack.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            outsideTrackVisible = false;
        }
    }
}
