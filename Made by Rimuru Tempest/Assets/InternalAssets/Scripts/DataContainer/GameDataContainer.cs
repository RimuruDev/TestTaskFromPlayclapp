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

        [SerializeField, HideInInspector] Transform[] transformInspectorHelper;
        public Transform[] GetTransformInspectorHelper => transformInspectorHelper;

        private void Start()
        {
            transformInspectorHelper = new Transform[2];
            transformInspectorHelper[(int)TransformInspectorHelper.SpawnPoin] = GameObject.FindGameObjectWithTag("Respawn").transform;
            transformInspectorHelper[(int)TransformInspectorHelper.InstanceParent] = GameObject.FindGameObjectWithTag("Runtime").transform;
        }
    }
}