using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace RimuruDev.FromPlayclapp
{
    public sealed class GameDataContainer : MonoBehaviour
    {
        [Header("Refs")]
        [SerializeField] private ObjectPool objectPool;
        [SerializeField] private SpawnController spawnController;
        [SerializeField] private UIController uiController;

        [Header("Object Pooling Settings")]
        [SerializeField] private List<GameObject> pooledObjects = null;
        [SerializeField] private int maxAmountPerPool = 100;
        [SerializeField] private float maxMotionDistance = 100;
        [SerializeField] private float spawnCooldown = 0.3f;

        [Header("Prefabs and points")]
        [SerializeField] private GameObject[] objectPrefab;
        [SerializeField] private Transform objectContainerParent;
        [SerializeField] private Transform spawnPoint;

        [Header("Cub Motion Settings")]
        [SerializeField] public float motionSpeed = 10;

        [Header("UI")]
        [SerializeField] private Text motionSpeedText;
        [SerializeField] private Text spawnCooldownText;
        [SerializeField] private Text maxDistanceText;
        [Space]
        [SerializeField] private TMP_InputField motionSpeedInputField;
        [SerializeField] private TMP_InputField spawnCooldownInputField;
        [SerializeField] private TMP_InputField maxDistanceInputField;

        // Note: I understand that it looks cumbersome. I am aware of the fact that I am breaking encapsulation.
        public ObjectPool ObjectPool { get => objectPool; set => objectPool = value; }
        public SpawnController SpawnController { get => spawnController; set => spawnController = value; }
        public UIController UiController { get => uiController; set => uiController = value; }

        public List<GameObject> PooledObjects { get => pooledObjects; set => pooledObjects = value; }
        public int MaxAmountPerPool { get => maxAmountPerPool; set => maxAmountPerPool = value; }
        public float MaxMotionDistance { get => maxMotionDistance; set => maxMotionDistance = value; }
        public float SpawnCooldown { get => spawnCooldown; set => spawnCooldown = value; }

        public GameObject[] ObjectPrefab { get => objectPrefab; set => objectPrefab = value; }
        public Transform ObjectContainerParent { get => objectContainerParent; set => objectContainerParent = value; }
        public Transform SpawnPoint { get => spawnPoint; set => spawnPoint = value; }

        public Text MotionSpeedText { get => motionSpeedText; set => motionSpeedText = value; }
        public Text SpawnCooldownText { get => spawnCooldownText; set => spawnCooldownText = value; }
        public Text MaxDistanceText { get => maxDistanceText; set => maxDistanceText = value; }

        public TMP_InputField MotionSpeedInputField { get => motionSpeedInputField; set => motionSpeedInputField = value; }
        public TMP_InputField SpawnCooldownInputField { get => spawnCooldownInputField; set => spawnCooldownInputField = value; }
        public TMP_InputField MaxDistanceInputField { get => maxDistanceInputField; set => maxDistanceInputField = value; }

        private void Awake() => InitRef();

        private void OnValidate() => InitRef();

        private void Reset()
        {
            MaxAmountPerPool = 100;
            MaxMotionDistance = 100;
            SpawnCooldown = 0.3f;
            motionSpeed = 10;

            if (SpawnPoint == null)
                SpawnPoint = GameObject.FindGameObjectWithTag("Finish").transform;

            if (ObjectContainerParent == null)
                ObjectContainerParent = GameObject.FindGameObjectWithTag("Runtime").transform;
        }

        private void InitRef()
        {
            if (ObjectPool == null)
                ObjectPool = FindObjectOfType<ObjectPool>();

            if (SpawnController == null)
                SpawnController = FindObjectOfType<SpawnController>();

            if (UiController == null)
                UiController = FindObjectOfType<UIController>();
        }
    }
}