using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrivingAidsMenuOptions : MonoBehaviour
{
    public EVP.VehicleController vehicleController;

    public void EnableTractionControl()
    {
        vehicleController.tractionControl = true;
    }

    public void DisableTractionControl()
    {
        vehicleController.tractionControl = false;
    }

    public void EnableBrakeAssist()
    {
        vehicleController.brakeAssist = true;
    }
    public void DisableBrakeAssist()
    {
        vehicleController.brakeAssist = false;
    }
}
