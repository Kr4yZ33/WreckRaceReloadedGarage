using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestToLastCheckpoint : MonoBehaviour
{
    public Player player;
    public GameObject car;
    
    public Transform cp1Reset;
    public Transform cp2Reset;
    public Transform cp3Reset;
    public Transform cp4Reset;
    public Transform cp5Reset;
    public Transform cp6Reset;
    public Transform cp7Reset;
    public Transform cp8Reset;
    public Transform cp9Reset;
    public Transform cp10Reset;

    Rigidbody r;

    void Awake()
    {
        r = car.GetComponent<Rigidbody>();
    }

    public void ResetToLastCheckpoint()
    {
        if(player.checkpointOne)
        {
            car.transform.position = cp1Reset.position;
            car.transform.rotation = cp1Reset.transform.rotation;
            r.velocity = Vector3.zero;
        }
        if (player.checkpointTwo)
        {
            car.transform.position = cp1Reset.position;
            car.transform.rotation = cp1Reset.transform.rotation;
            r.velocity = Vector3.zero;
        }
        if (player.checkpointThree)
        {
            car.transform.position = cp2Reset.position;
            car.transform.rotation = cp2Reset.transform.rotation;
            r.velocity = Vector3.zero;
        }
        if (player.checkpointFour)
        {
            car.transform.position = cp3Reset.position;
            car.transform.rotation = cp3Reset.transform.rotation;
            r.velocity = Vector3.zero;
        }
        if (player.checkpointFive)
        {
            car.transform.position = cp4Reset.position;
            car.transform.rotation = cp4Reset.transform.rotation;
            r.velocity = Vector3.zero;
        }
        if (player.checkpointSix)
        {
            car.transform.position = cp5Reset.position;
            car.transform.rotation = cp5Reset.transform.rotation;
            r.velocity = Vector3.zero;
        }
        if (player.checkpointSeven)
        {
            car.transform.position = cp6Reset.position;
            car.transform.rotation = cp6Reset.transform.rotation;
            r.velocity = Vector3.zero;
        }
        if (player.checkpointEight)
        {
            car.transform.position = cp7Reset.position;
            car.transform.rotation = cp7Reset.transform.rotation;
            r.velocity = Vector3.zero;
        }
        if (player.checkpointNine)
        {
            car.transform.position = cp8Reset.position;
            car.transform.rotation = cp8Reset.transform.rotation;
            r.velocity = Vector3.zero;
        }
        if (player.checkpointTen)
        {
            car.transform.position = cp9Reset.position;
            car.transform.rotation = cp9Reset.transform.rotation;
            r.velocity = Vector3.zero;
        }
    }
}
