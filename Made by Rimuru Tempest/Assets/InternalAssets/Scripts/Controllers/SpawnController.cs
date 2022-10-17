using UnityEngine;
using System.Collections;

namespace RimuruDev.FromPlayclapp
{
    public sealed class SpawnController : MonoBehaviour
    {
        [SerializeField] private GameDataContainer dataContainer;

        private void Awake() => InitRef();

        private void Start() => StartCoroutine(nameof(SpawnCube));

        private void OnValidate() => InitRef();

        private IEnumerator SpawnCube()
        {
            while (true)
            {
                var currentCub = dataContainer.ObjectPool.GetPoolingObjects();

                if (currentCub != null)
                    currentCub.SetActive(true);

                yield return new WaitForSeconds(dataContainer.SpawnCooldown);
            }
        }

        private void InitRef()
        {
            if (dataContainer == null)
                dataContainer = FindObjectOfType<GameDataContainer>();
        }
    }
}