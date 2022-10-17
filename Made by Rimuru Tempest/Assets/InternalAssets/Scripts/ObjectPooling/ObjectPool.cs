using UnityEngine;

namespace RimuruDev.FromPlayclapp
{
    public sealed class ObjectPool : MonoBehaviour
    {
        [SerializeField] private GameDataContainer dataContainer;

        private void Awake() => InitRef();

        private void Start() => PopulatingObjectPool();

        private void OnValidate() => InitRef();

        public GameObject GetPoolingObjects()
        {
            for (int i = 0; i < dataContainer.PooledObjects.Count; i++)
            {
                if (!dataContainer.PooledObjects[i].activeInHierarchy)
                {
                    return dataContainer.PooledObjects[i];
                }
            }

            return default;
        }

        private void PopulatingObjectPool()
        {
            for (int i = 0; i < dataContainer.MaxAmountPerPool; i++)
            {
                var cube = Instantiate(dataContainer.CubePrefab, dataContainer.SpawnPoint);
                cube.transform.SetParent(dataContainer.ObjectContainerParent);
                cube.SetActive(false);

                dataContainer.PooledObjects.Add(cube);
            }
        }

        private void InitRef()
        {
            if (dataContainer == null)
                dataContainer = FindObjectOfType<GameDataContainer>();
        }
    }
}