using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

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

    [Serializable]
    public struct InputFieldNode
    {
        public TMP_InputField InputField => inputField;
        [SerializeField] private TMP_InputField inputField;

        public Text Text => text;
        [SerializeField] private Text text;
    }
}