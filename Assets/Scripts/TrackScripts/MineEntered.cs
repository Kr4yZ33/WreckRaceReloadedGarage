using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineEntered : MonoBehaviour
{
    public bool playerEnteredMine;
    public MineExited mineExited;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerEnteredMine = true;
            mineExited.playerExitedMine = false;
        }
    }
}
