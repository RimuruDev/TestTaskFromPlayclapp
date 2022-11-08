using UnityEngine;
using TMPro;

namespace RimuruDev.FromPlayclapp
{
    [System.Serializable]
    public sealed class InputFielContainer
    {
        [SerializeField] private TMP_InputField motionSpeedInputField;
        public TMP_InputField MotionSpeedInputField { get => motionSpeedInputField; set => motionSpeedInputField = value; }

        [SerializeField] private TMP_InputField spawnCooldownInputField;
        public TMP_InputField SpawnCooldownInputField { get => spawnCooldownInputField; set => spawnCooldownInputField = value; }

        [SerializeField] private TMP_InputField maxDistanceInputField;
        public TMP_InputField MaxDistanceInputField { get => maxDistanceInputField; set => maxDistanceInputField = value; }
    }
}