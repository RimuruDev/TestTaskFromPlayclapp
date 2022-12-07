using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace RimuruDev.FromPlayclapp.MVC
{
    [Serializable]
    public struct InputFieldNode
    {
        public TMP_InputField InputField => inputField;
        [SerializeField] private TMP_InputField inputField;

        public float CurrentValue { get => currentValue; set => currentValue = Mathf.Clamp(value, 0, 1000); }
        private float currentValue;

        public Text Text => text;
        [SerializeField] private Text text;
    }
}