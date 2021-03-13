using System;
using UnityEngine;
using UnityEngine.UI;

public class CurrentCheckpoint : MonoBehaviour
{
    public Player player;

    [SerializeField] private Text checkpointText;
    [SerializeField] private string previousText;
    [SerializeField] private int decimalPlaces;

    void Update()
    {
        if (player == null)
        {
            return;
        }

        if (player.lastCheckpointPassed == 0)
        {
            checkpointText.text = previousText + " 1";
        }
        else
        {
            checkpointText.text = previousText + player.currentCheckpoint.ToString();
        }

    }
}
