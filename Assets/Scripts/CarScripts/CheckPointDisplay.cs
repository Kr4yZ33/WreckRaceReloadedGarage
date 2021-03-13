using System;
using UnityEngine;
using UnityEngine.UI;

public class CheckPointDisplay : MonoBehaviour
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

        checkpointText.text = previousText + player.lastCheckpointPassed.ToString();
    }
}