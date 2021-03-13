using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    //Combined score

    public int playerFinalScore = 0;

    
    //hit score

    public int hitTotalScore = 0;

    //damage score
    
    public int damageTotalScore = 0;

    // time scores
    public float checkpointTwoTargetTime;
    public float checkpointThreeTargetTime;
    public float checkpointFourTargetTime;
    public float checkpointFiveTargetTime;
    public float checkpointSixTargetTime;
    public float checkpointSevenTargetTime;
    public float checkpointEightTargetTime;
    public float checkpointNineTargetTime;
    public float checkpointTenTargetTime;

    public float checkpointTwoActualTime;
    public float checkpointThreeActualTime;
    public float checkpointFourActualTime;
    public float checkpointFiveActualTime;
    public float checkpointSixActualTime;
    public float checkpointSevenActualTime;
    public float checkpointEightActualTime;
    public float checkpointNineActualTime;
    public float checkpointTenActualTime;

    public int checkpointTotalScore = 0;
    public GameObject timeScoreCanvas;
    public GameObject totalScoreCanvas;

    [SerializeField] private Text totalScoreText;
    [SerializeField] private Text damageScoreText;
    [SerializeField] private Text hitsScoreText;

    [SerializeField] private Text targetTimeText;
    [SerializeField] private Text actualTimeText;
    [SerializeField] private Text totalTimeScoreText;
    //[SerializeField] private string previousText;
    [SerializeField] private int decimalPlaces;

    public void CalculateCheckpointTimeDifference()
    {
        if(checkpointTwoActualTime > checkpointTwoTargetTime)
        {
            checkpointTotalScore -= 10;
        }

        if (checkpointTwoActualTime <= checkpointTwoTargetTime)
        {
            checkpointTotalScore += 10;
        }

        if (checkpointThreeActualTime > checkpointThreeTargetTime)
        {
            checkpointTotalScore -= 10;
        }
        if (checkpointThreeActualTime <= checkpointThreeTargetTime)
        {
            checkpointTotalScore += 10;
        }

        if (checkpointFourActualTime > checkpointFourTargetTime)
        {
            checkpointTotalScore -= 10;
        }
        if (checkpointFourActualTime <= checkpointFourTargetTime)
        {
            checkpointTotalScore += 10;
        }

        if (checkpointFiveActualTime > checkpointFiveTargetTime)
        {
            checkpointTotalScore -= 10;
        }
        if (checkpointFiveActualTime <= checkpointFiveTargetTime)
        {
            checkpointTotalScore += 10;
        }

        if (checkpointSixActualTime > checkpointSixTargetTime)
        {
            checkpointTotalScore -= 10;
        }
        if (checkpointSixActualTime <= checkpointSixTargetTime)
        {
            checkpointTotalScore += 10;
        }

        if (checkpointSevenActualTime > checkpointSevenTargetTime)
        {
            checkpointTotalScore -= 10;
        }
        if (checkpointSevenActualTime <= checkpointSevenTargetTime)
        {
            checkpointTotalScore += 10;
        }

        if (checkpointEightActualTime > checkpointEightTargetTime)
        {
            checkpointTotalScore -= 10;
        }
        if (checkpointEightActualTime <= checkpointEightTargetTime)
        {
            checkpointTotalScore += 10;
        }

        if (checkpointNineActualTime > checkpointNineTargetTime)
        {
            checkpointTotalScore -= 10;
        }
        if (checkpointNineActualTime <= checkpointNineTargetTime)
        {
            checkpointTotalScore += 10;
        }

        if (checkpointTenActualTime > checkpointTenTargetTime)
        {
            checkpointTotalScore -= 10;
        }
        if (checkpointTenActualTime <= checkpointTenTargetTime)
        {
            checkpointTotalScore += 10;
        }

        timeScoreCanvas.SetActive(true);
        totalScoreCanvas.SetActive(true);
        DisplayCheckpointTargetTimes();
        DisplayCheckpointActualTimes();
        DisplayTotalTimeScore();
        DisplayHitScoreText();
        DisplayDamageScoreText();
        DisplayTotalScoreText();

    }

    void DisplayCheckpointTargetTimes()
    {
        targetTimeText.text = "CP2 T " + checkpointTwoTargetTime.ToString() + " CP3 T " + checkpointThreeTargetTime.ToString() + " CP4 T " + checkpointFourTargetTime.ToString() + " CP5 T " + checkpointFiveTargetTime.ToString() + " CP6 T " + checkpointSixTargetTime.ToString() + " CP7 T " + checkpointSevenTargetTime.ToString() + " CP8 T " + checkpointEightTargetTime.ToString() + " CP9 T " + checkpointNineTargetTime.ToString() + " CP10 T " + checkpointTenTargetTime.ToString();
    }

    void DisplayCheckpointActualTimes()
    {
        actualTimeText.text = "CP2 " + checkpointTwoActualTime.ToString() + " CP3 " + checkpointThreeActualTime.ToString() + " CP4 " + checkpointFourActualTime.ToString() + " CP5 " + checkpointFiveActualTime.ToString() + " CP6 " + checkpointSixActualTime.ToString() + " CP7 " + checkpointSevenActualTime.ToString() + " CP8 " + checkpointEightActualTime.ToString() + " CP9 " + checkpointNineActualTime.ToString() + " CP10 " + checkpointTenActualTime.ToString();
    }

    void DisplayTotalTimeScore()
    {
        totalTimeScoreText.text = checkpointTotalScore.ToString();
    }

    void DisplayHitScoreText()
    {
        hitsScoreText.text = "Hit " + hitTotalScore.ToString();
    }

    void DisplayDamageScoreText()
    {
        damageScoreText.text = "DMG " + damageTotalScore.ToString();
    }

    void DisplayTotalScoreText()
    {
        playerFinalScore = checkpointTotalScore + hitTotalScore + damageTotalScore;
        totalScoreText.text = "TOT " + playerFinalScore.ToString();
    }
}
