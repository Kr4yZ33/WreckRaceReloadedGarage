using UnityEngine;
using BattSys;

public class Player : MonoBehaviour
{
    //public enum ControlType { HumanInput, AI }
    //public ControlType controlType = ControlType.HumanInput;

    //public float BestLapTime { get; private set; } = Mathf.Infinity;
    //public float LastLapTime { get; private set; } = 0;

    //public float BestCheckPointTime { get; private set; } = Mathf.Infinity;
    public float LastCheckPointTime { get; private set; } = 0;
    
    public float CurrentCheckpointTime { get; private set; } = 0;
    //public float CurrentLapTime { get; private set; } = 0;
    //public int CurrentLap { get; private set; } = 0;

    //float lapTimer;
    float checkpointTimer;
    public int lastCheckpointPassed = 0;
    public int checkpointCount;
    public int currentCheckpoint;
    int checkpointLayer;
    //int longJumpLayer;
    Transform checkpointsParent;
    // add CarController carController

    public bool checkpointOne = true;
    public bool checkpointTwo;
    public bool checkpointThree;
    public bool checkpointFour;
    public bool checkpointFive;
    public bool checkpointSix;
    public bool checkpointSeven;
    public bool checkpointEight;
    public bool checkpointNine;
    public bool checkpointTen;

    public ScoreManager scoreManager;
    public BattleSystem battleSystem;

    private void Awake()
    {
        checkpointsParent = GameObject.Find("Checkpoints").transform;
        checkpointCount = checkpointsParent.childCount;
        checkpointLayer = LayerMask.NameToLayer("Checkpoint");
        // carController = GetComponent<CarController>();
        //longJumpLayer = LayerMask.NameToLayer("LongJump");
        
    }

    void StartCheckpoint()
    {
        //Debug.Log("Start Checkpoint");
        currentCheckpoint = lastCheckpointPassed + 1;
        checkpointTimer = Time.time;
    }

    //void StartLap()
    //{
        //Debug.Log("Start Lap");
        //CurrentLap++;
        //lastCheckpointPassed = 1;
        //lapTimer = Time.time; // time stamp
    //}

    void EndCheckpoint()
    {
        if(lastCheckpointPassed == 1)
        {
            return;
        }
        
        
        //BestCheckPointTime = Mathf.Min(LastCheckPointTime, BestCheckPointTime);
        //Debug.Log("End Checkpoint - Time was " + LastCheckPointTime + " seconds");
        if(lastCheckpointPassed == 2)
        {
            scoreManager.checkpointTwoActualTime = LastCheckPointTime;
        }
        if (lastCheckpointPassed == 3)
        {
            scoreManager.checkpointThreeActualTime = LastCheckPointTime;
        }
        if (lastCheckpointPassed == 4)
        {
            scoreManager.checkpointFourActualTime = LastCheckPointTime;
        }
        if (lastCheckpointPassed == 5)
        {
            scoreManager.checkpointFiveActualTime = LastCheckPointTime;
        }
        if (lastCheckpointPassed == 6)
        {
            scoreManager.checkpointSixActualTime = LastCheckPointTime;
        }
        if (lastCheckpointPassed == 7)
        {
            scoreManager.checkpointSevenActualTime = LastCheckPointTime;
        }
        if (lastCheckpointPassed == 8)
        {
            scoreManager.checkpointEightActualTime = LastCheckPointTime;
        }
        if (lastCheckpointPassed == 9)
        {
            scoreManager.checkpointNineActualTime = LastCheckPointTime;
        }
        if (lastCheckpointPassed == 10)
        {
            scoreManager.checkpointTenActualTime = LastCheckPointTime;
            return;
        }

        StartCheckpoint();
    }

    //void EndLap()
    //{
        //LastLapTime = Time.time - lapTimer;
        //BestLapTime = Mathf.Min(LastLapTime, BestLapTime);
        //Debug.Log("End Lap - LapTime was " + LastLapTime + " seconds");
    //}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer != checkpointLayer) //|| other.gameObject.layer != longJumpLayer)
        {
            return;
        }

        if(other.gameObject.name == "1")
        {
            StartCheckpoint();
            lastCheckpointPassed = 1;

            //if(lastCheckpointPassed == checkpointCount)
            //{
            //EndLap();
            //}

            //if(CurrentLap == 0 || lastCheckpointPassed == checkpointCount) // if current lap is equal to zero, or last checkpoint passed equals the last checkpoint
            //{
            //StartLap();
            //}
            //return;
        }

        //If we have passed the next checkpoint in the sequence, update the latest checkpoint
        if(other.gameObject.name != "1")
        {
            if (other.gameObject.name == (lastCheckpointPassed + 1).ToString())
            {
                LastCheckPointTime = CurrentCheckpointTime;
                lastCheckpointPassed++;
                EndCheckpoint();
            }
        }

        if(lastCheckpointPassed == checkpointCount)
        {
            scoreManager.CalculateCheckpointTimeDifference();

            if(other.gameObject.name == "J1")
            {
                Debug.Log("J1 20 Points");
                // add 20 points
                // mark landing point
                // spawn jump prefab marker at vehicle landing point
            }

            if (other.gameObject.name == "J2")
            {
                Debug.Log("J2 40 Points");
                // add 40 points
                // mark landing point
                // spawn jump prefab marker at vehicle landing point
            }

            if (other.gameObject.name == "J3")
            {
                Debug.Log("J3 60 Points");
                // add 60 points
                // mark landing point
                // spawn jump prefab marker at vehicle landing point
            }

            if (other.gameObject.name == "J4")
            {
                Debug.Log("J4 80 Points");
                // add 80 points
                // mark landing point
                // spawn jump prefab marker at vehicle landing point
            }

            if (other.gameObject.name == "J5")
            {
                Debug.Log("J5 100 Points");
                // add 100 points
                // mark landing point 
                // spawn jump prefab marker at vehicle landing point
            }

            if (other.gameObject.name == "J6")
            {
                Debug.Log("J6 150 Points WR");
                // update record long jump if jump is greater (add extra 50 points to score if new record jump or equal to it)
                // add 100 points
                // mark landing point
                // spawn jump prefab marker at vehicle landing point (record has it's own landing marker that's special)
                // spawn fireworks
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        //CurrentLapTime = lapTimer > 0 ? Time.time - lapTimer : 0;
        CurrentCheckpointTime = checkpointTimer > 0 ? Time.time - checkpointTimer : 0;
    }
    void FixedUpdate()
    {
        if (lastCheckpointPassed == 1)
        {
            battleSystem.NewRaceStarted();
            checkpointOne = false;
            checkpointTwo = true;
        }
        if (lastCheckpointPassed == 2)
        {
            checkpointTwo = false;
            checkpointThree = true;
        }
        if (lastCheckpointPassed == 3)
        {
            checkpointThree = false;
            checkpointFour = true;
        }
        if (lastCheckpointPassed == 4)
        {
            checkpointFour = false;
            checkpointFive = true;
        }
        if (lastCheckpointPassed == 5)
        {
            checkpointFive = false;
            checkpointSix = true;
        }
        if (lastCheckpointPassed == 6)
        {
            checkpointSix = false;
            checkpointSeven = true;
        }
        if (lastCheckpointPassed == 7)
        {
            checkpointSeven = false;
            checkpointEight = true;
        }
        if (lastCheckpointPassed == 8)
        {
            checkpointEight = false;
            checkpointNine = true;
        }
        if (lastCheckpointPassed == 9)
        {
            checkpointNine = false;
            checkpointTen = true;
        }
        if (lastCheckpointPassed == 10)
        {
            checkpointTen = false;
        }

    }
}
