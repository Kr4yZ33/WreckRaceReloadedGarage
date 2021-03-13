using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisabledObjectController : MonoBehaviour
{
    public bool controlsLeftHandLeft;
    public bool controlsLeftHandRight;
    public bool controlsRightHandLeft;
    public bool controlsRightHandRight;

    public void LeftControlLeftHand()
    {
        controlsLeftHandLeft = true;
        controlsLeftHandRight = false;
    }

    public void LeftControlRightHand()
    {
        controlsLeftHandRight = true;
        controlsLeftHandLeft = false;
    }

    public void RightControlLeftHand()
    {
        controlsRightHandLeft = true;
        controlsRightHandRight = false;
    }

    public void RightControlRightHand()
    {
        controlsRightHandRight = true;
        controlsRightHandLeft = false;
    }
}
