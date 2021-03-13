using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform raceStartTransform;
    public GameObject car;
    Rigidbody r;

    void Awake()
    {
        r = car.GetComponent<Rigidbody>();    
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            other.transform.position = raceStartTransform.position;
            other.transform.rotation = raceStartTransform.transform.rotation;
            r.velocity = Vector3.zero;
        }
    }
}
