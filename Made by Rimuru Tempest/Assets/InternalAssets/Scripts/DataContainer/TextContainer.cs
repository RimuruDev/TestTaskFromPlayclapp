using UnityEngine;
using UnityEngine.UI;

namespace RimuruDev.FromPlayclapp
{
    [System.Serializable]
    public sealed class TextContainer
    {
        [SerializeField] private Text motionSpeedText;
        public Text MotionSpeedText { get => motionSpeedText; set => motionSpeedText = value; }

        [SerializeField] private Text spawnCooldownText;
        public Text SpawnCooldownText { get => spawnCooldownText; set => spawnCooldownText = value; }

        [SerializeField] private Text maxDistanceText;
        public Text MaxDistanceText { get => maxDistanceText; set => maxDistanceText = value; }
    }
}