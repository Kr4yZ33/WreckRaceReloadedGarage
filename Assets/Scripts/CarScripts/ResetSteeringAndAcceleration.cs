using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetSteeringAndAcceleration : MonoBehaviour
{
    public EVP.VehicleStandardInput vehicleInput;

    public void ResetCarMovement()
    {
        vehicleInput.acceleration = false;
        vehicleInput.acceleration1 = false;
        vehicleInput.acceleration2 = false;
        vehicleInput.resetSteering = true;
        vehicleInput.braking = false;
    }
}
