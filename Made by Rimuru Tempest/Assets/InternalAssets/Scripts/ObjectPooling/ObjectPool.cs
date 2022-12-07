using UnityEngine;

namespace RimuruDev.FromPlayclapp
{
    public sealed class ObjectPool : MonoBehaviour
    {
        [SerializeField, HideInInspector] private GameDataContainer dataContainer;

        private void Awake() => InitRef();

        private void Start() => PopulatingObjectPool();

        private void OnValidate() => InitRef();

        public GameObject GetPoolingObjects()
        {
            //for (int i = 0; i < dataContainer.PooledObjects.Count; i++)
            //{
            //    if (!dataContainer.PooledObjects[i].activeInHierarchy)
            //    {
            //      //  return dataContainer.PooledObjects[i];//
            //    }
            //}

            return default;
        }

        private void PopulatingObjectPool()
        {
            for (int i = 0; i < dataContainer.GetGameplaySettings.MaxAmountPerPool; i++)
            {
                var rndIndex = UnityEngine.Random.Range(0, dataContainer.GetGameplaySettings.GetPrefabsForSpawn.Length);

                var cube = Instantiate(dataContainer.GetGameplaySettings.GetPrefabsForSpawn[rndIndex], dataContainer.GetTransformInspectorHelper[(int)TransformInspectorHelper.SpawnPoin]);

                cube.transform.SetParent(dataContainer.GetTransformInspectorHelper[(int)TransformInspectorHelper.InstanceParent]);
                cube.SetActive(false);

               // dataContainer.PooledObjects.Add(cube);
            }
        }

        private void InitRef()
        {
            if (dataContainer == null)
                dataContainer = FindObjectOfType<GameDataContainer>();
        }
    }
}