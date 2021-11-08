using UnityEngine;
using static Assets.Scripts.FengGameManagerMKII;

namespace Assets.Scripts.Utility
{

    public class SpectatorMode
    {

        private static SpectatorMovement _specMovement;

        public static void Initialize()
        {
            _specMovement = GameObject.Find("MainCamera").GetComponent<SpectatorMovement>();
        }

        public static SpectatorMovement Get()
        {
            return _specMovement;
        }

        public static bool IsDisable()
        {
            return _specMovement.disable;
        }

        public static void Toggle()
        {
            _specMovement.disable = !_specMovement.disable;
        }

        public static void Disable()
        {
            _specMovement.disable = true;
        }

        public static void Enable()
        {
            _specMovement.enabled = false;
        }

    }

}