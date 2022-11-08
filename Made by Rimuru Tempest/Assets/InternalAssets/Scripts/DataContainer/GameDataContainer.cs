using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace RimuruDev.FromPlayclapp
{
    public sealed class GameDataContainer : MonoBehaviour
    {
        [SerializeField] private GameplaySettings gameplaySettings;
        public GameplaySettings GetGameplaySettings => gameplaySettings;

        [SerializeField, HideInInspector] private ObjectPool objectPool;
        [SerializeField, HideInInspector] private SpawnController spawnController;
        [SerializeField, HideInInspector] private UIController uiController;

        [SerializeField, HideInInspector] private List<GameObject> pooledObjects = null;
        public List<GameObject> PooledObjects { get => pooledObjects; set => pooledObjects = value; }

        [SerializeField, HideInInspector] Transform[] transformInspectorHelper;
        public Transform[] GetTransformInspectorHelper => transformInspectorHelper;

        [SerializeField] private InputFielContainer inputFielContainer = new InputFielContainer();
        public InputFielContainer InputFielContainer { get => inputFielContainer; set => inputFielContainer = value; }

        [SerializeField] private TextContainer textContainer = new TextContainer();
        public TextContainer TextContainer { get => textContainer; set => textContainer = value; }

        private void Start()
        {
            transformInspectorHelper = new Transform[2];
            transformInspectorHelper[(int)TransformInspectorHelper.SpawnPoin] = GameObject.FindGameObjectWithTag("Respawn").transform;
            transformInspectorHelper[(int)TransformInspectorHelper.InstanceParent] = GameObject.FindGameObjectWithTag("Runtime").transform;
        }
    }
}