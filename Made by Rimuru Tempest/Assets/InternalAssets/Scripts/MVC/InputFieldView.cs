using UnityEngine;

namespace RimuruDev.FromPlayclapp.MVC
{
    public sealed class InputFieldView : MonoBehaviour
    {
        [SerializeField] private InputFieldNode motionSpeed;
        [SerializeField] private InputFieldNode spawnCooldown;
        [SerializeField] private InputFieldNode distance;

        private InputFieldController inputFieldController = null;

        private void Awake() => inputFieldController = new(motionSpeed, spawnCooldown, distance);
    }
}