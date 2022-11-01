using UnityEngine;

namespace RimuruDev.FromPlayclapp
{
    public sealed class ObjectMotionController : MonoBehaviour
    {   
        [SerializeField] private GameDataContainer dataContainer;

        private void Awake() => InitRef();

        private void Update()
        {
            Motion();

            if (transform.position.z >= dataContainer.MaxMotionDistance)
            {
                gameObject.SetActive(false);

                ReturnCubeObject();
            }
        }

        private void OnValidate() => InitRef();

        private void Motion() => transform.Translate(0, 0, dataContainer.motionSpeed * Time.deltaTime);

        private void ReturnCubeObject() => transform.position = dataContainer.SpawnPoint.position;

        private void InitRef()
        {
            if (dataContainer == null)
                dataContainer = FindObjectOfType<GameDataContainer>();
        }
    }
}