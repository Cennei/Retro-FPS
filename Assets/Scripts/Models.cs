using System;
using System.Collections.Generic;
using UnityEngine;

public static class Models
{
    #region - Player -

    public enum PlayerStance
    {
        Stand,
        Crouch,
        Prone
    }

    [Serializable]
    public class PlayerSettingsModel
    {
        [Header("View Settings")]
        public float ViewXSensitivity;
        public float ViewYSensitivity;

        public bool ViewXInverted;
        public bool ViewYInverted;

        [Header("Movement Settings")]
        public bool SprintingOnHold;
        public float MovementSmoothing;

        [Header("Movement - Walking")]
        public float WalkingForwardSpeed;
        public float WalkingBackwardSpeed;
        public float WalkingStrafeSpeed;

        [Header("Movement - Running")]
        public float RunningForwardSpeed;
        public float RunningStrafeSpeed;

        [Header("Jumping")]
        public float JumpingHeight;
        public float JumpingFalloff;
        public float FallingSmoothing;

        [Header("Speed Effectors")]
        public float SpeedEffector = 1;
        public float CrouchSpeedEffector;
        public float ProneSpeedEffector;
        public float FallingSpeedEffector;

    }
    
    [Serializable]
    public class CharacterStance
    {
        public float CameraHeight;
        public CapsuleCollider StanceCollider;
    }

    #endregion

    #region - Weapons -

    [Serializable]
    public class WeaponSettingsModel
    {
        [Header("Sway")]
        public float SwayAmount;
        public float SwaySmoothing;
    }

    #endregion
}
