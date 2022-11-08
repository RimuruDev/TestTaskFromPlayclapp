using UnityEngine;

namespace RimuruDev.FromPlayclapp
{
    public sealed class ObjectMotionController : MonoBehaviour
    {
        [SerializeField, HideInInspector] private GameDataContainer dataContainer;

        private void Awake() => InitRef();

        private void Update()
        {
            Motion();

            if (transform.position.z >= dataContainer.GetGameplaySettings.MaxMotionDistance)
            {
                gameObject.SetActive(false);

                ReturnCubeObject();
            }
        }

        [System.Diagnostics.Conditional("DEBUG")]
        private void OnValidate() => InitRef();

        private void Motion() => transform.Translate(0, 0, dataContainer.GetGameplaySettings.MotionSpeed * Time.deltaTime);

        private void ReturnCubeObject() => transform.position = dataContainer.GetTransformInspectorHelper[(int)TransformInspectorHelper.SpawnPoin].position;

        private void InitRef()
        {
            if (dataContainer == null)
                dataContainer = FindObjectOfType<GameDataContainer>();
        }
    }
}