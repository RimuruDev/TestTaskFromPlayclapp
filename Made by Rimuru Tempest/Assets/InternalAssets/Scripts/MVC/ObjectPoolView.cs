using System;
using System.Collections.Generic;
using UnityEngine;

using Random = UnityEngine.Random;

namespace RimuruDev.FromPlayclapp
{
    public sealed class ObjectPoolView : MonoBehaviour
    {
        public ObjectPoopSettings ObjectPoopSettings => objectPoopSettings;
        [SerializeField] private ObjectPoopSettings objectPoopSettings;

        private ObjectPoolController objectPoolController = null;

        private void Awake() => objectPoolController = new(objectPoopSettings);

        private void Start() => objectPoolController.PopulatingObjectPool();
    }

    [Serializable]
    public struct ObjectPoopSettings
    {
        public int MaxAmountPerPool => maxAmountPerPool;
        [SerializeField] private int maxAmountPerPool;

        public List<GameObject> ObjectForSpawned => objectForSpawned;
        [SerializeField] private List<GameObject> objectForSpawned;

        public Transform Placeholder => placeholder;
        [SerializeField] private Transform placeholder;

        public Transform SpawnPoint => spawnPoint;
        [SerializeField] private Transform spawnPoint;
    }

    public sealed class ObjectPoolModel
    {
        public ObjectPoopSettings ObjectPoopSettings => objectPoopSettings;
        private ObjectPoopSettings objectPoopSettings;

        public ObjectPoolModel(ObjectPoopSettings objectPoopSettings) => this.objectPoopSettings = objectPoopSettings;

    }

    public sealed class ObjectPoolController
    {
        private readonly ObjectPoolModel objectPoolModel = null;

        public ObjectPoolController(ObjectPoopSettings objectPoopSettings) => objectPoolModel = new(objectPoopSettings);

        public GameObject GetPoolingObjects()
        {
            for (int i = 0; i < objectPoolModel.ObjectPoopSettings.ObjectForSpawned.Count; i++)
            {
                if (!objectPoolModel.ObjectPoopSettings.ObjectForSpawned[i].activeInHierarchy)
                {
                    return objectPoolModel.ObjectPoopSettings.ObjectForSpawned[i];
                }
            }

            return default;
        }

        public void PopulatingObjectPool()
        {
            for (int i = 0; i < objectPoolModel.ObjectPoopSettings.MaxAmountPerPool; i++)
            {
                var rndIndex = Random.Range(0, objectPoolModel.ObjectPoopSettings.ObjectForSpawned.Count);

                var cube = UnityEngine.Object.Instantiate(
                    objectPoolModel.ObjectPoopSettings.ObjectForSpawned[rndIndex],
                    objectPoolModel.ObjectPoopSettings.SpawnPoint);

                cube.transform.SetParent(objectPoolModel.ObjectPoopSettings.Placeholder);
                cube.SetActive(false);
            }
        }
    }
}