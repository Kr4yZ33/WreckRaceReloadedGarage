using UnityEngine;
using UnityEngine.UI;
using BattSys;

public class CarHitBehaviour : MonoBehaviour
{
    public ScoreManager scoreManager;
    public BattleSystem battleSystem;

    public enum CarHitStates { Undamaged, LightDmg, MediumDmg, HeavyDmg, FullDmg }
    public CarHitStates currentCarHitState;

    // undamaged state
    public bool resetCarState;
    // light state
    bool damageLevel1;
    public GameObject lightDamageEffects;
    // medium state
    bool damageLevel2;
    public GameObject mediumDamageEffects;
    // heavy state
    bool damageLevel3;
    public GameObject heavyDamageEffects;
    // full state
    bool damageLevel4;
    public GameObject fullDamageEffects;

    public AudioSource audioSource;
    public AudioClip carHeavyHitClip;
    public float volume = 0.3f;

    [SerializeField] private Text damageText;
    [SerializeField] private string previousText;
    [SerializeField] private int decimalPlaces;

    public int carDamage = 0;

    void Start()
    {
        currentCarHitState = CarHitStates.Undamaged;
    }

    void Update()
    {
        damageText.text = previousText + carDamage.ToString();
    }

    void LateUpdate()
    {
        HandleUndamagedState();
        HandleLightDamageState();
        HandleMediumDamageState();
        HandleHeavyDamageState();
        HandleFullDamageState();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("HeavyWeapon"))
        {
            carDamage += 3;
            audioSource.PlayOneShot(carHeavyHitClip);
            Destroy(other);
        }
    }

    void HandleUndamagedState()
    {
        if(!resetCarState)
        {
            return;
        }
        else
        {
            if(currentCarHitState != CarHitStates.Undamaged)
            {
                currentCarHitState = CarHitStates.Undamaged;
            }
            carDamage = 0;
            damageLevel1 = false;
            damageLevel2 = false;
            damageLevel3 = false;
            damageLevel4 = false;
            lightDamageEffects.SetActive(false);
            mediumDamageEffects.SetActive(false);
            heavyDamageEffects.SetActive(false);
            fullDamageEffects.SetActive(false);
            resetCarState = false;
        }  
    }

    void HandleLightDamageState()
    {
        if (damageLevel1)
        {
            return;
        }
        if (carDamage > 29 && carDamage < 60)
        {
            if (currentCarHitState != CarHitStates.LightDmg)
            {
                currentCarHitState = CarHitStates.LightDmg;
            }
            lightDamageEffects.SetActive(true);
            scoreManager.damageTotalScore -= 30;
            damageLevel1 = true;
        }
    }

    void HandleMediumDamageState()
    {
        if (damageLevel2)
        {
            return;
        }

        if (carDamage > 59 && carDamage < 90)
        {
            if (currentCarHitState != CarHitStates.MediumDmg)
            {
                currentCarHitState = CarHitStates.MediumDmg;
            }
            mediumDamageEffects.SetActive(true);
            scoreManager.damageTotalScore -= 30;
            damageLevel2 = true;
        }
    }

    void HandleHeavyDamageState()
    {
        if (damageLevel3)
        {
            return;
        }
        if (carDamage > 89 && carDamage < 100)
        {
            if (currentCarHitState != CarHitStates.HeavyDmg)
            {
                currentCarHitState = CarHitStates.HeavyDmg;
            }
            heavyDamageEffects.SetActive(true);
            scoreManager.damageTotalScore -= 30;
            damageLevel3 = true;
        }
    }

    void HandleFullDamageState()
    {
        if (damageLevel4)
        {
            return;
        }
        if (carDamage >= 100)
        {
            if (currentCarHitState != CarHitStates.FullDmg)
            {
                currentCarHitState = CarHitStates.FullDmg;
            }
            fullDamageEffects.SetActive(true);
            battleSystem.carFullDamage = true;
            scoreManager.damageTotalScore -= 10;
            damageLevel4 = true;
        }
    }

    public void ResetCarDamage()
    {
        resetCarState = true;
    }
}
