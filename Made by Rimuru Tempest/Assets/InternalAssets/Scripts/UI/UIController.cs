using System;
using UnityEngine;
using UnityEngine.UI;

namespace RimuruDev.FromPlayclapp
{
    //public sealed class UIController : MonoBehaviour
    //{
    //    [SerializeField, HideInInspector] private GameDataContainer dataContainer;

    //    private void Awake() => CheckRefs();

    //    private void Start()
    //    {
    //        dataContainer.InputFielContainer.MotionSpeedInputField.onValueChanged.AddListener(delegate { EnterMotionSpeed(); });
    //        dataContainer.InputFielContainer.MaxDistanceInputField.onValueChanged.AddListener(delegate { EnterMaxDistance(); });
    //        dataContainer.InputFielContainer.SpawnCooldownInputField.onValueChanged.AddListener(delegate { EnterSpawnCooldown(); });

    //        dataContainer.InputFielContainer.MotionSpeedInputField.text = $"{dataContainer.GetGameplaySettings.MotionSpeed}";
    //        dataContainer.InputFielContainer.SpawnCooldownInputField.text = $"{dataContainer.GetGameplaySettings.SpawnCooldown}";
    //        dataContainer.InputFielContainer.MaxDistanceInputField.text = $"{dataContainer.GetGameplaySettings.MaxMotionDistance}";
    //    }

    //    private void OnDestroy()
    //    {
    //        dataContainer.InputFielContainer.MotionSpeedInputField.onValueChanged.RemoveListener(delegate { EnterMotionSpeed(); });
    //        dataContainer.InputFielContainer.MaxDistanceInputField.onValueChanged.RemoveListener(delegate { EnterMaxDistance(); });
    //        dataContainer.InputFielContainer.SpawnCooldownInputField.onValueChanged.RemoveListener(delegate { EnterSpawnCooldown(); });
    //    }

    //    [System.Diagnostics.Conditional("DEBUG")]
    //    private void OnValidate() => CheckRefs();

    //    public void EnterMotionSpeed()
    //    {
    //        float previousValue = dataContainer.GetGameplaySettings.MotionSpeed;

    //        if (float.TryParse(dataContainer.InputFielContainer.MotionSpeedInputField.text, out float result))
    //        {
    //            if (result < 0) result = previousValue;
    //            if (result == 0) result = 0.01f;
    //            if (result >= ushort.MaxValue / 2) result = previousValue;

    //            dataContainer.GetGameplaySettings.MotionSpeed = result;
    //            dataContainer.TextContainer.MotionSpeedText.text = $"Motion speed: {dataContainer.GetGameplaySettings.MotionSpeed}";
    //        }
    //    }

    //    public void EnterSpawnCooldown()
    //    {
    //        float previousValue = dataContainer.GetGameplaySettings.SpawnCooldown;

    //        if (float.TryParse(dataContainer.InputFielContainer.SpawnCooldownInputField.text, out float result))
    //        {
    //            if (result < 0) result = previousValue;
    //            if (result == 0) result = 0.01f;
    //            if (result >= ushort.MaxValue / 2) result = previousValue;

    //            dataContainer.GetGameplaySettings.SpawnCooldown = result;
    //            dataContainer.TextContainer.SpawnCooldownText.text = $"Spawn cooldown: {dataContainer.GetGameplaySettings.SpawnCooldown}";
    //        }

    //    }

    //    public void EnterMaxDistance()
    //    {
    //        float previousValue = dataContainer.GetGameplaySettings.MaxMotionDistance;

    //        if (float.TryParse(dataContainer.InputFielContainer.MaxDistanceInputField.text, out float result))
    //        {
    //            if (result < 0) result = previousValue;
    //            if (result == 0) result = 0.01f;
    //            if (result >= ushort.MaxValue / 2) result = previousValue;

    //            dataContainer.GetGameplaySettings.MaxMotionDistance = result;
    //            dataContainer.TextContainer.MaxDistanceText.text = $"Max distance: {dataContainer.GetGameplaySettings.MaxMotionDistance}";
    //        }
    //    }

    //    private void CheckRefs()
    //    {
    //        if (dataContainer == null)
    //            dataContainer = FindObjectOfType<GameDataContainer>();
    //    }
    //}
}