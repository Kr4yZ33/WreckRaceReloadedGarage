using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BattSys;

public class GatlingGun : MonoBehaviour
{
    public BattleSystem battleSystem; // reference to our BattleSystem script

    public enum GatlingGunStates { Idle, Spooling, Shooting }
    public GatlingGunStates currentGatlingGunState;

    // Idle state
    public Transform cannonForwardReset;

    // Spooling state
    public Transform cannonTarget;  // target the gun will aim at
    public float firingRange; // Distance the GG can aim and fire from
    // Gameobjects need to control rotation and aiming
    public Transform go_baseRotation;
    public Transform go_GunBody;
    public Transform go_barrel;
    // Gatling Gun barrel rotation
    public float barrelRotationSpeed;
    float currentRotationSpeed;
    RaycastHit hit; // reference to what our Raycast hits

    // Shooting Auto State
    public ParticleSystem muzzelFlash; // Particle system for the muzzel flash
    public bool muzzelFlashPlaying;
    public AudioSource shootingAudio; // audiosource for shooting sound

    public Transform currentTargetName;
    public bool C1Destroyed;
    public bool C2Destroyed;
    public bool C3Destroyed;
    public bool C4Destroyed;
    public bool C5Destroyed;

    void Start()
    {
        currentGatlingGunState = GatlingGunStates.Idle;
    }

    //Update happens once per frame
    void Update()
    {
        currentTargetName = cannonTarget;

        if(currentTargetName.name == "C1" && C1Destroyed == true)
        {
            battleSystem.canFire = false;
        }
        if (currentTargetName.name == "C2" && C2Destroyed == true)
        {
            battleSystem.canFire = false;
        }
        if (currentTargetName.name == "C3" && C3Destroyed == true)
        {
            battleSystem.canFire = false;
        }
        if (currentTargetName.name == "C4" && C4Destroyed == true)
        {
            battleSystem.canFire = false;
        }
        if (currentTargetName.name == "C5" && C5Destroyed == true)
        {
            battleSystem.canFire = false;
        }

        if (Physics.Linecast(go_barrel.position, cannonTarget.transform.position, out hit)) // send a raycast out from the GG barrel towards the cannon's target
        {
            //Debug.Log("Raw hit info" + hit.collider.name);

            if (hit.collider.gameObject.CompareTag("Enemy") || hit.collider.name == "CannonShot" || hit.collider.name == "CannonShot(Clone)") // if we hit a collider with the tag Enemy, or we collide with something named CannonSHot or CannonShot(Clone)
            {
                //Debug.Log("LOS Clear"); // debug to log LOS Clear
                battleSystem.lineOfSightBlocked = false; // set the bool for Line Of Sight Blocked to True
            }
            else // otherwise
            {
                //Debug.Log("LOS Blocked" + hit.collider.name); // debug to log LOS blocked and the name of what's blocking LOS
                battleSystem.lineOfSightBlocked = true; // set the bool for Line Of SIght Blocked to True
            }
        }
    }

    void LateUpdate()
    {
        if (battleSystem.manualAim)
        {
            cannonTarget = battleSystem.manualShootingTarget;
            if(battleSystem.lineOfSightBlocked)
            {
                battleSystem.canFire = false;
            }
            else
            {
                battleSystem.canFire = true;
            }
        }
        if (!battleSystem.manualAim && !battleSystem.targetInRange)
        {
            battleSystem.canFire = false;
        }
        HandleIdleState();
        HandleSpoolingState();
        HandleShootingState();


    }

    void OnDrawGizmosSelected()
    {
        // Draw a red sphere at the transform's position to show the firing range
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, firingRange);
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.layer != 8)
        {
            return;
        }
        if (other.gameObject.layer == 8)
        {
            battleSystem.canFire = true;
            battleSystem.targetInRange = true;
            cannonTarget = other.transform;
        }
    }

    // on trigger stay
    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.layer != 8)
        {
            return;
        }
        
        else
        {
            if (battleSystem.manualAim)
            {
                return;
            }

            else
            {
                cannonTarget = other.transform;
            }
        } 
    }

    // Stop firing
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.layer != 8)
        {
            return;
        }
        
        else
        {
            battleSystem.targetInRange = false;

        }
    }


    void HandleIdleState()
    {
        if(!battleSystem.targetInRange)
        {
            if (currentGatlingGunState != GatlingGunStates.Idle)
            {
                currentGatlingGunState = GatlingGunStates.Idle;
            }

            // slow down barrel rotation and stop
            currentRotationSpeed = Mathf.Lerp(currentRotationSpeed, 0, 10 * Time.deltaTime);
            cannonTarget = cannonForwardReset;
            Vector3 baseTargetPostition = new Vector3(cannonTarget.position.x, this.transform.position.y, cannonTarget.position.z);
            Vector3 gunBodyTargetPostition = new Vector3(cannonTarget.position.x, cannonTarget.position.y, cannonTarget.position.z);
            go_baseRotation.transform.LookAt(baseTargetPostition);
            go_GunBody.transform.LookAt(gunBodyTargetPostition);

            // stop the particle system
            if (muzzelFlashPlaying)
            {
                muzzelFlash.Stop();
                shootingAudio.enabled = false;
                muzzelFlashPlaying = false;
            }
        }
    }

    void HandleSpoolingState()
    {
        if(battleSystem.targetInRange)
        {
            if (battleSystem.lineOfSightBlocked || !battleSystem.canFire)
            {
                if (currentGatlingGunState != GatlingGunStates.Spooling)
                {
                    currentGatlingGunState = GatlingGunStates.Spooling;
                }

                if (muzzelFlashPlaying)
                {
                    muzzelFlash.Stop();
                    shootingAudio.enabled = false;
                    muzzelFlashPlaying = false;
                    return;
                }
                else
                {
                    // Gun barrel rotation
                    go_barrel.transform.Rotate(0, 0, currentRotationSpeed * Time.deltaTime);
                    // start rotation
                    currentRotationSpeed = barrelRotationSpeed;
                    // aim at enemy
                    Vector3 baseTargetPostition = new Vector3(cannonTarget.position.x, this.transform.position.y, cannonTarget.position.z);
                    Vector3 gunBodyTargetPostition = new Vector3(cannonTarget.position.x, cannonTarget.position.y, cannonTarget.position.z);
                    go_baseRotation.transform.LookAt(baseTargetPostition);
                    go_GunBody.transform.LookAt(gunBodyTargetPostition);
                }
            }
        }  
    }

    void HandleShootingState()
    {
        if(battleSystem.targetInRange && !battleSystem.lineOfSightBlocked && battleSystem.canFire)
        {
            if (currentGatlingGunState != GatlingGunStates.Shooting)
            {
                currentGatlingGunState = GatlingGunStates.Shooting;
            }

            // Gun barrel rotation
            go_barrel.transform.Rotate(0, 0, currentRotationSpeed * Time.deltaTime);
            // start rotation
            currentRotationSpeed = barrelRotationSpeed;
            // aim at enemy
            Vector3 baseTargetPostition = new Vector3(cannonTarget.position.x, this.transform.position.y, cannonTarget.position.z);
            Vector3 gunBodyTargetPostition = new Vector3(cannonTarget.position.x, cannonTarget.position.y, cannonTarget.position.z);
            go_baseRotation.transform.LookAt(baseTargetPostition);
            go_GunBody.transform.LookAt(gunBodyTargetPostition);

            if(muzzelFlashPlaying == true)
            {
                return;
            }
            else
            {
                muzzelFlash.Play();
                muzzelFlashPlaying = true;
                shootingAudio.enabled = true;
            }
        }
    }
}