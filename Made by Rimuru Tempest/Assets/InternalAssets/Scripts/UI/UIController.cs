using UnityEngine;
using UnityEngine.UI;

namespace RimuruDev.FromPlayclapp
{
    public sealed class UIController : MonoBehaviour
    {
        [SerializeField] private GameDataContainer dataContainer;

        private void Start()
        {
            dataContainer.MotionSpeedInputField.text = dataContainer.motionSpeed.ToString();
            dataContainer.SpawnCooldownInputField.text = dataContainer.SpawnCooldown.ToString();
            dataContainer.MaxDistanceInputField.text = dataContainer.MaxMotionDistance.ToString();
        }

        private void Update()
        {
            dataContainer.MotionSpeedText.text = $"Motion speed: {dataContainer.motionSpeed}";
            dataContainer.motionSpeed = float.Parse(dataContainer.MotionSpeedInputField.text);

            dataContainer.SpawnCooldownText.text = $"Spawn cooldown: {dataContainer.SpawnCooldown}";
            dataContainer.SpawnCooldown = float.Parse(dataContainer.SpawnCooldownInputField.text);

            dataContainer.MaxDistanceText.text = $"Max distance: {dataContainer.MaxMotionDistance}";
            dataContainer.MaxMotionDistance = float.Parse(dataContainer.MaxDistanceInputField.text);

        }
    }
}