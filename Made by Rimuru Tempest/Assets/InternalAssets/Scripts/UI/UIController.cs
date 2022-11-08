using System;
using UnityEngine;
using UnityEngine.UI;

namespace RimuruDev.FromPlayclapp
{
    public sealed class UIController : MonoBehaviour
    {
        [SerializeField] private GameDataContainer dataContainer;

        private void Awake()
        {
            if (dataContainer == null)
                dataContainer = FindObjectOfType<GameDataContainer>();
        }

        private void Start()
        {

            dataContainer.MotionSpeedInputField.text = dataContainer.motionSpeed.ToString();
            dataContainer.SpawnCooldownInputField.text = dataContainer.SpawnCooldown.ToString();
            dataContainer.MaxDistanceInputField.text = dataContainer.MaxMotionDistance.ToString();

            dataContainer.MotionSpeedText.text = $"Motion speed: {dataContainer.motionSpeed}";
            dataContainer.SpawnCooldownText.text = $"Spawn cooldown: {dataContainer.SpawnCooldown}";
            dataContainer.MaxDistanceText.text = $"Max distance: {dataContainer.MaxMotionDistance}";

            dataContainer.MotionSpeedInputField.onValueChanged.AddListener(delegate { EnterMotionSpeed(); });
            dataContainer.MaxDistanceInputField.onValueChanged.AddListener(delegate { EnterMaxDistance(); });
            dataContainer.SpawnCooldownInputField.onValueChanged.AddListener(delegate { EnterSpawnCooldown(); });
        }


        private void OnDestroy()
        {
            dataContainer.MotionSpeedInputField.onValueChanged.RemoveListener(delegate { EnterMotionSpeed(); });
            dataContainer.MaxDistanceInputField.onValueChanged.RemoveListener(delegate { EnterMaxDistance(); });
            dataContainer.SpawnCooldownInputField.onValueChanged.RemoveListener(delegate { EnterSpawnCooldown(); });
        }

        public void EnterMotionSpeed()
        {
            float previousValue = dataContainer.motionSpeed;

            if (float.TryParse(dataContainer.MotionSpeedInputField.text, out float result))
            {
                if (result < 0)
                    result = previousValue;

                if (result == 0)
                    result = 0.01f;

                if (result >= short.MaxValue)
                    result = previousValue;

                dataContainer.motionSpeed = result;
                dataContainer.MotionSpeedText.text = $"Motion speed: {dataContainer.motionSpeed}";
            }
        }

        public void EnterSpawnCooldown()
        {
            float previousValue = dataContainer.SpawnCooldown;

            if (float.TryParse(dataContainer.SpawnCooldownInputField.text, out float result))
            {
                if (result < 0)
                    result = previousValue;

                if (result == 0)
                    result = 0.01f;

                if (result >= short.MaxValue)
                    result = previousValue;

                dataContainer.SpawnCooldown = result;
                dataContainer.SpawnCooldownText.text = $"Spawn cooldown: {dataContainer.SpawnCooldown}";
            }

        }

        public void EnterMaxDistance()
        {
            float previousValue = dataContainer.MaxMotionDistance;

            if (float.TryParse(dataContainer.MaxDistanceInputField.text, out float result))
            {
                if (result < 0)
                    result = previousValue;

                if (result == 0)
                    result = 0.01f;

                if (result >= short.MaxValue)
                    result = previousValue;

                dataContainer.MaxMotionDistance = result;
                dataContainer.MaxDistanceText.text = $"Max distance: {dataContainer.MaxMotionDistance}";
            }
        }
    }
}