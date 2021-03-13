using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalToStart : MonoBehaviour
{
    public Transform raceStartTransform;
    
        private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            other.transform.position = raceStartTransform.position;
            other.transform.rotation = raceStartTransform.rotation;
        }
    }
}
