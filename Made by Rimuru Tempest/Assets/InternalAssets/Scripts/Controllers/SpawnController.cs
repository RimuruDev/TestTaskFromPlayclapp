using UnityEngine;
using System.Collections;

namespace RimuruDev.FromPlayclapp
{
    public sealed class SpawnController : MonoBehaviour
    {
        [SerializeField, HideInInspector] private GameDataContainer dataContainer;
        [SerializeField, HideInInspector] private ObjectPool objectPool;

        private void Awake() => InitRefs();

        private void Start() => StartCoroutine(nameof(SpawnCube));

        private void OnValidate() => InitRefs();

        private IEnumerator SpawnCube()
        {
            while (true)
            {
                var currentCub = objectPool.GetPoolingObjects();

                if (currentCub != null)
                    currentCub.SetActive(true);

                yield return new WaitForSeconds(dataContainer.GetGameplaySettings.SpawnCooldown);
            }
        }

        [System.Diagnostics.Conditional("DEBUG")]
        private void InitRefs()
        {
            if (dataContainer == null)
                dataContainer = FindObjectOfType<GameDataContainer>();

            if (objectPool == null)
                objectPool = FindObjectOfType<ObjectPool>();
        }
    }
}