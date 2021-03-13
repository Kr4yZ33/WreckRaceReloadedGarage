using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EVP;
using BattSys;
using UnityEngine.InputSystem;

public class DrivingControlsInterface : MonoBehaviour
{
    public VehicleStandardInput vehicleInput;
    public BattleSystem battleSystem;
    public DisabledObjectController disabledObjectController;

    public InputActionAsset inputActions;

    public bool leftHand = true;
    public bool rightHand;
    
    public bool nitrous;
    public VehicleNitro vehicleNitro;
    public GameObject nitrousSound;

    Vector3 moveVec;

    public GatlingGun gatlingGun;
    public BoostButton ggLight;

    void OnEnable()
    {
        if (disabledObjectController.controlsLeftHandLeft)
        {
            ChangHandToLeft();
        }

        if (disabledObjectController.controlsLeftHandRight)
        {
            ChangeHandToRight();
        }
    }

    public void OnNOS(InputValue input)
    {
        float nos = input.Get<float>();

        if (nos == 1)
        {
            vehicleNitro.nitrous = true;
            nitrousSound.SetActive(true);
        }
        else
        {
            vehicleNitro.nitrous = false;
            nitrousSound.SetActive(false);
        }
    }

    public void OnBrake(InputValue input)
    {
        float brake = input.Get<float>();
        //Debug.Log(brake + " Brake Value");

        if (brake == 1)
        {
            vehicleInput.braking = true;
        }
        else
        {
            vehicleInput.braking = false;
        }
    }

    public void OnHandBrake(InputValue input)
    {
        float handBrake = input.Get<float>();

        if (handBrake == 1)
        {
            vehicleInput.handbrakeOverridesThrottle = true;
        }
        else
        {
            vehicleInput.handbrakeOverridesThrottle = false;
        }
    }

    public void OnSteering(InputValue input)
    {
        Vector2 inputVec = input.Get<Vector2>();

        moveVec = new Vector3(inputVec.x, 0, inputVec.y);
        //Debug.Log(inputVec.x + " InputVec.x value");

        if (inputVec.x < 0)
        {
            //Debug.Log("Turn Left");
            vehicleInput.turnLeftHard = true;
        }

        if (inputVec.x > 0)
        {
            //Debug.Log("Turn Right");
            vehicleInput.turnRightHard = true;
        }

        if (inputVec == Vector2.zero)
        {
            //Debug.Log("No Turn");
            vehicleInput.turnRightHard = false;
            vehicleInput.turnLeftHard = false;
        }
    }

    public void OnAcceleration(InputValue input)
    {
        float accelerate = input.Get<float>();

        //Debug.Log(accelerate + " Accelerate Value");

        if (accelerate == 1)
        {
            //Debug.Log("Accelerate Pressed");
            vehicleInput.acceleration = true;
        }
        else
        {
            //Debug.Log("Accelerate NOT Pressed");
            vehicleInput.acceleration = false;
        }
    }
    public void OnGatlingGunManualAim(InputValue input)
    {
        float ggAim = input.Get<float>();

        if (ggAim == 1)
        {
            ToggleGatlingGunManualAim();
        }
        else
        {
            ToggleGatlingGunManualAim();
        }
    }

    public void ChangHandToLeft()
    {
        leftHand = true;
        rightHand = false;
    }

    public void ChangeHandToRight()
    {
        rightHand = true;
        leftHand = false;
    }

    public void ToggleNOS()
    {
        if (nitrous)
        {
            nitrous = false;
            vehicleNitro.nitrous = false;
            nitrousSound.SetActive(false);
            return;
        }
        else if (!nitrous)
        {
            nitrous = true;
            vehicleNitro.nitrous = true;
            nitrousSound.SetActive(true);
        }
    }

    public void HandbrakeOn()
    {
        vehicleInput.handbrakeOverridesThrottle = true;
    }

    public void HandbrakeOff()
    {
        vehicleInput.handbrakeOverridesThrottle = false;
    }


    public void ToggleGatlingGunManualAim()
    {
        if (battleSystem.manualAim)
        {
            battleSystem.manualAim = false;
            ggLight.MakeButtonRed();
            return;
        }
        else if (!battleSystem.manualAim)
        {
            ggLight.MakeButtonGreen();
            battleSystem.manualAim = true;
        }
    }
}
