using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineExited : MonoBehaviour
{
    public bool playerExitedMine;
    public MineEntered mineEntered;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerExitedMine = true;
            mineEntered.playerEnteredMine = false;
        }
    }
}
