using System;
using UnityEngine;
using UnityEngine.UI;

public class CheckPointTime : MonoBehaviour
{
    public Player player;

    [SerializeField] private Text timeText;
    [SerializeField] private string previousText;
    [SerializeField] private int decimalPlaces;

    void Update()
    {
        if (player == null)
        {
            return;
        }

        timeText.text = previousText + player.LastCheckPointTime.ToString();
    }
}