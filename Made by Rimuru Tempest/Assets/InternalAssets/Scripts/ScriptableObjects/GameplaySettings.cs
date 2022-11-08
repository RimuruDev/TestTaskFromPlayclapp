using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RimuruDev.FromPlayclapp
{
    [CreateAssetMenu(fileName = "new GameplaySettings", menuName = "Gameplay Settings", order = 0)]
    public class GameplaySettings : ScriptableObject
    {
        [Header("Pool settings")]
        [SerializeField] private int maxAmountPerPool = 100;
        public int MaxAmountPerPool { get => maxAmountPerPool; set => maxAmountPerPool = Mathf.Clamp(value, 0, ushort.MaxValue); }

        [Header("Spawn settings")]
        [SerializeField] private float spawnCooldown = 0.3f;
        public float SpawnCooldown { get => spawnCooldown; set => spawnCooldown = Mathf.Clamp(value, 0.01f, ushort.MaxValue); }

        [Header("Object prefabs for spawn")]
        [SerializeField] private GameObject[] prefabsForSpawn;
        public GameObject[] GetPrefabsForSpawn => prefabsForSpawn;

        [Header("Player settings")]
        [SerializeField] private float maxMotionDistance = 100;
        public float MaxMotionDistance { get => maxMotionDistance; set => maxMotionDistance = Mathf.Clamp(value, 0, ushort.MaxValue); }

        [SerializeField] private float motionSpeed = 10;
        public float MotionSpeed { get => motionSpeed; set => motionSpeed = Mathf.Clamp(value, 0, ushort.MaxValue); }

        private void Reset()
        {
            MaxAmountPerPool = 100;
            MaxMotionDistance = 100;
            spawnCooldown = 0.3f;
            MotionSpeed = 10;

            Debug.Log("Please set ref for Prefabs for Spawn. Seted default PrimitiveType.Cube");
        }
    }
}