using System;
using UnityEngine;
using UnityEngine.UI;

public class CheckPointTimeCurrent : MonoBehaviour
{
    public Player player;

    [SerializeField] private Text checkpointTimeText;
    [SerializeField] private string previousText;
    [SerializeField] private int decimalPlaces;

    void Update()
    {
        if (player == null)
        {
            return;
        }

        checkpointTimeText.text = previousText + player.CurrentCheckpointTime.ToString();
    }
}
