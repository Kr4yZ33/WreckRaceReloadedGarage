using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSectionControllerUndergroundTrack : MonoBehaviour
{
    public MineEntered mineEntered;
    public MineExited mineExited;
    public GameObject belowGroundTrack;
    bool belowGroundTrackVisible = true;


    void FixedUpdate()
    {
        if(!belowGroundTrackVisible)
        {
            belowGroundTrack.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            belowGroundTrack.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (mineEntered.playerEnteredMine)
            {
                return;
            }
            else
            {
                belowGroundTrackVisible = false;
            }
        }
    }
}
