using UnityEngine;
using BattSys;

public class ResetRace : MonoBehaviour
{
    public Player player;
    public BattleSystem battleSystem;
    public CarHitBehaviour carHitBehaviour;
    public ScoreManager scoreManager;
    public GatlingGun gatlingGun;

    public Transform raceStartTransform;
    public GameObject car;
    Rigidbody r;

    void Awake()
    {
        r = car.GetComponent<Rigidbody>();
    }

    public void ResetRaceConditions()
    {
        player.lastCheckpointPassed = 0;
        player.currentCheckpoint = 0;
        player.checkpointOne = true;
        player.checkpointTwo = false;
        player.checkpointThree = false;
        player.checkpointFour = false;
        player.checkpointFive = false;
        player.checkpointSix = false;
        player.checkpointSeven = false;
        player.checkpointEight = false;
        player.checkpointNine = false;
        player.checkpointTen = false;


        scoreManager.checkpointTwoActualTime = 0;
        scoreManager.checkpointThreeActualTime = 0;
        scoreManager.checkpointFourActualTime = 0;
        scoreManager.checkpointFiveActualTime = 0;
        scoreManager.checkpointSixActualTime = 0;
        scoreManager.checkpointSevenActualTime = 0;
        scoreManager.checkpointEightActualTime = 0;
        scoreManager.checkpointNineActualTime = 0;
        scoreManager.checkpointTenActualTime = 0;
        scoreManager.playerFinalScore = 0;
        scoreManager.hitTotalScore = 0;
        scoreManager.damageTotalScore = 0;
        scoreManager.checkpointTotalScore = 0;

        carHitBehaviour.resetCarState = true;
        
        battleSystem.carFullDamage = false;

        gatlingGun.C1Destroyed = false;
        gatlingGun.C2Destroyed = false;
        gatlingGun.C3Destroyed = false;
        gatlingGun.C4Destroyed = false;
        gatlingGun.C5Destroyed = false;

        car.transform.position = raceStartTransform.position;
        car.transform.rotation = raceStartTransform.transform.rotation;
        r.velocity = Vector3.zero;
    }
}
