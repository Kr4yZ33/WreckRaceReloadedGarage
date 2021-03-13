using UnityEngine;

namespace BattSys
{
    public class BattleSystem : MonoBehaviour
    {
        // Gatling Gun
        public bool targetInRange;
        public bool lineOfSightBlocked;
        public bool canFire;
        public bool manualAim;
        public bool carFullDamage;

        public Transform manualShootingTarget;

        // Cannons
        public bool playerInRange;
        public bool raceReset;

        public void NewRaceStarted()
        {
            raceReset = false;
        }
    }
}



