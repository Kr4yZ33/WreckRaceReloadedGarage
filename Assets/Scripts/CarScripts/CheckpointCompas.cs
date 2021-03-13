using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointCompas : MonoBehaviour
{
    public Player player;
    Transform go_target;
    Transform go_baseRotation;

    public GameObject checkpointOne;
    public GameObject checkpointTwo;
    public GameObject checkpointThree;
    public GameObject checkpointFour;
    public GameObject checkpointFive;
    public GameObject checkpointSix;
    public GameObject checkpointSeven;
    public GameObject checkpointEight;
    public GameObject checkpointNine;
    public GameObject checkpointTen;

    void Awake()
    {
        go_baseRotation = gameObject.transform;
        
    }

    void FixedUpdate()
    {
        if(player == null)
        {
            return;
        }
        
        if(player.checkpointOne)
        {
            go_target = checkpointOne.transform;
            Vector3 baseTargetPostition = new Vector3(go_target.position.x, this.transform.position.y, go_target.position.z);
            go_baseRotation.transform.LookAt(baseTargetPostition);
        }

        if (player.checkpointTwo)
        {
            go_target = checkpointTwo.transform;
            Vector3 baseTargetPostition = new Vector3(go_target.position.x, this.transform.position.y, go_target.position.z);
            go_baseRotation.transform.LookAt(baseTargetPostition);
        }

        if (player.checkpointThree)
        {
            go_target = checkpointThree.transform;
            Vector3 baseTargetPostition = new Vector3(go_target.position.x, this.transform.position.y, go_target.position.z);
            go_baseRotation.transform.LookAt(baseTargetPostition);
        }

        if (player.checkpointFour)
        {
            go_target = checkpointFour.transform;
            Vector3 baseTargetPostition = new Vector3(go_target.position.x, this.transform.position.y, go_target.position.z);
            go_baseRotation.transform.LookAt(baseTargetPostition);
        }

        if (player.checkpointFive)
        {
            go_target = checkpointFive.transform;
            Vector3 baseTargetPostition = new Vector3(go_target.position.x, this.transform.position.y, go_target.position.z);
            go_baseRotation.transform.LookAt(baseTargetPostition);
        }

        if (player.checkpointSix)
        {
            go_target = checkpointSix.transform;
            Vector3 baseTargetPostition = new Vector3(go_target.position.x, this.transform.position.y, go_target.position.z);
            go_baseRotation.transform.LookAt(baseTargetPostition);
        }

        if (player.checkpointSeven)
        {
            go_target = checkpointSeven.transform;
            Vector3 baseTargetPostition = new Vector3(go_target.position.x, this.transform.position.y, go_target.position.z);
            go_baseRotation.transform.LookAt(baseTargetPostition);
        }

        if (player.checkpointEight)
        {
            go_target = checkpointEight.transform;
            Vector3 baseTargetPostition = new Vector3(go_target.position.x, this.transform.position.y, go_target.position.z);
            go_baseRotation.transform.LookAt(baseTargetPostition);
        }

        if (player.checkpointNine)
        {
            go_target = checkpointNine.transform;
            Vector3 baseTargetPostition = new Vector3(go_target.position.x, this.transform.position.y, go_target.position.z);
            go_baseRotation.transform.LookAt(baseTargetPostition);
        }

        if (player.checkpointTen)
        {
            go_target = checkpointTen.transform;
            Vector3 baseTargetPostition = new Vector3(go_target.position.x, this.transform.position.y, go_target.position.z);
            go_baseRotation.transform.LookAt(baseTargetPostition);
        }
    }
}
