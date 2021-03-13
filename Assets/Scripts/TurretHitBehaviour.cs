using System.Collections;
using UnityEngine;
using BattSys;

public class TurretHitBehaviour : MonoBehaviour
{
    public GatlingGun gatlingGun;
    public BattleSystem battleSystem;
    public Cannon cannon;
    public ScoreManager scoreManager;

    public enum CannonHitStates {Undamaged,LightDmg,MediumDmg,HeavyDmg,FullDmg }
    public CannonHitStates currentCannonHitState;

    // undamaged state
    public bool resetCannonDamage;

    // light state
    public GameObject lightDamage;
    bool damageLevel1;
    // medium state
    public GameObject mediumDamage;
    bool damageLevel2;
    // heavy state
    public GameObject heavyDamage;
    bool damageLevel3;
    // full state
    public GameObject fullDamage;
    bool damageLevel4;

    int cannonDamage = 0;
    bool addDamage = true; // True or false statement regarding if we can shoot yet or not (following the shot delay)
    public float timeBetweenShots = 0.1f; // 0.1 second between each shot

    void Start()
    {
        currentCannonHitState = CannonHitStates.Undamaged;
    }

    void Update()
    {
        if (battleSystem.lineOfSightBlocked)
        {
            return;
        }

        else if (cannon.inRange && battleSystem.lineOfSightBlocked == false)
        {
            CannonTakingDamage();
        }
    }

    void LateUpdate()
    {
        HandleUndamagedState();
        HandleLightDamageState();
        HandleMediumDamageState();
        HandleHeavyDamageState();
        HandleFullDamageState();
    }

    void FixedUpdate()
    {
        if (battleSystem.raceReset)
        {
            resetCannonDamage = true;
        }
    }

    void CannonTakingDamage()
    {
        if (!addDamage)
        {
            return;
        }
        else
        {
            cannonDamage += 1;
            addDamage = false;
            StartCoroutine(ShootDelay()); // start the shoot delay coroutine
        }
    }

    /// <summary>
    /// Our delay between shots
    /// </summary>
    /// <returns></returns>
    IEnumerator ShootDelay()
    {
        yield return new WaitForSeconds(timeBetweenShots); // Amount of time we wait
        addDamage = true; // set the can Shoot bool to True
    }

    void HandleUndamagedState()
    {
        if(!resetCannonDamage)
        {
            return;
        }
        if (currentCannonHitState != CannonHitStates.Undamaged)
        {
            currentCannonHitState = CannonHitStates.Undamaged;
        }
        cannonDamage = 0;
        damageLevel1 = false;
        damageLevel2 = false;
        damageLevel3 = false;
        damageLevel4 = false;
        lightDamage.SetActive(false);
        mediumDamage.SetActive(false);
        heavyDamage.SetActive(false);
        fullDamage.SetActive(false);
        resetCannonDamage = false;
    }

    void HandleLightDamageState()
    {
        if(damageLevel1)
        {
            return;
        }
        if (cannonDamage > 29 && cannonDamage < 60)
        {
            if(currentCannonHitState != CannonHitStates.LightDmg)
            {
                currentCannonHitState = CannonHitStates.LightDmg;
            }
            scoreManager.hitTotalScore += 5;
            lightDamage.SetActive(true);
            damageLevel1 = true;
        }
    }

    void HandleMediumDamageState()
    {
        if (damageLevel2)
        {
            return;
        }

        if (cannonDamage > 59 && cannonDamage < 90)
        {
            if (currentCannonHitState != CannonHitStates.MediumDmg)
            {
                currentCannonHitState = CannonHitStates.MediumDmg;
            }
            scoreManager.hitTotalScore += 5;
            mediumDamage.SetActive(true);
            damageLevel2 = true;
        }
    }

    void HandleHeavyDamageState()
    {
        if (damageLevel3)
        {
            return;
        }
        if (cannonDamage > 89 && cannonDamage < 100)
        {
            if (currentCannonHitState != CannonHitStates.HeavyDmg)
            {
                currentCannonHitState = CannonHitStates.HeavyDmg;
            }
            scoreManager.hitTotalScore += 5;
            heavyDamage.SetActive(true);
            damageLevel3 = true;
        }  
    }

    void HandleFullDamageState()
    {
        if (damageLevel4)
        {
            return;
        }
        if (cannonDamage == 100)
        {
            if (currentCannonHitState != CannonHitStates.FullDmg)
            {
                currentCannonHitState = CannonHitStates.FullDmg;
            }
            scoreManager.hitTotalScore += 5;
            fullDamage.SetActive(true);
            cannon.cannonDestroyed = true;
            damageLevel4 = true;
        }
    }

    public void ResetCannonDamage()
    {
        resetCannonDamage = true;
    }
}
