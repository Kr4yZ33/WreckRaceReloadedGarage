using System.Collections;
using UnityEngine;
using BattSys;

public class Cannon : MonoBehaviour
{
    public BattleSystem battleSystem;
    public GatlingGun gatlingGun;
    
    public enum CannonStates {Idle, Shooting, Destroyed }
    public CannonStates currentCannonState;

    // Idle state


    //Shooting State
    

    // target the gun will aim at
    Transform cannonTarget;
    // Distance the turret can aim and fire from
    public bool canShoot = true;
    public bool inRange; // Bool for if player is in range of cannon
    // Gameobjects need to control rotation and aiming
    public Transform go_GunBody;

    public GameObject shotPrefab;
    public float shotForce = 1000;
    public float timeBetweenShots = 2.0f; // 1 second between each shot
    public Transform shotSpawnLocation;
    public ParticleSystem shotEffect;


    // Destroyed State
    public bool cannonDestroyed;

    void Start()
    {
        currentCannonState = CannonStates.Idle;
    }

    void LateUpdate()
    {
        HandleIdleState();
        HandleShootingState();
        HandleDestroyedState();
    }
    void FixedUpdate()
    {
        if(battleSystem.raceReset)
        {
            cannonDestroyed = false;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inRange = true;
            cannonTarget = other.transform;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inRange = false;
        }
    }

    void HandleIdleState()
    {
        if(!inRange)
        {
            if(currentCannonState != CannonStates.Idle)
            {
                currentCannonState = CannonStates.Idle;
            }
        }
    }

    void HandleShootingState()
    {
               
        // if can fire turret activates
        if (inRange && battleSystem.lineOfSightBlocked != true && !cannonDestroyed)
        {
            if (currentCannonState != CannonStates.Shooting)
            {
                currentCannonState = CannonStates.Shooting;
            }
            // aim at enemy
            Vector3 gunBodyTargetPostition = new Vector3(cannonTarget.position.x, cannonTarget.position.y, cannonTarget.position.z);
            go_GunBody.transform.LookAt(gunBodyTargetPostition);

            if(!canShoot)
            {
                return;
            }
            else
            {
                GameObject clone = Instantiate(shotPrefab, shotSpawnLocation.position, shotSpawnLocation.rotation);
                clone.GetComponent<Rigidbody>().AddForce(shotSpawnLocation.forward * shotForce);
                shotEffect.Play();
                canShoot = false;
                StartCoroutine(ShootDelay()); // start the shoot delay coroutine
            }
        }     
    }

    /// <summary>
    /// Our delay between shots
    /// </summary>
    /// <returns></returns>
    IEnumerator ShootDelay()
    {
        yield return new WaitForSeconds(timeBetweenShots); // Amount of time we wait
        canShoot = true; // set the can Shoot bool to True
    }

    void HandleDestroyedState()
    {
        if(!inRange)
        {
            return;
        }

        if(cannonDestroyed)
        {
            if(currentCannonState != CannonStates.Destroyed)
            {
                currentCannonState = CannonStates.Destroyed;
            }

            if (gameObject.name == "C1")
            {
                gatlingGun.C1Destroyed = true;
            }
            else if (gameObject.name == "C2")
            {
                gatlingGun.C2Destroyed = true;
            }
            else if (gameObject.name == "C3")
            {
                gatlingGun.C3Destroyed = true;
            }
            else if (gameObject.name == "C4")
            {
                gatlingGun.C4Destroyed = true;
            }
            else if (gameObject.name == "C5")
            {
                gatlingGun.C5Destroyed = true;
            }
        }
    }
}