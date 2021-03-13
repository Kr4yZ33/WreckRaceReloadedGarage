using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotOcclusion : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }


    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 2 || collision.gameObject.layer == 16)
        {
            Destroy(gameObject);
        }
    }

}
