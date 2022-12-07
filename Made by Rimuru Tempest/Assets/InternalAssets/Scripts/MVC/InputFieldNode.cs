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

        public Text Text => text;
        [SerializeField] private Text text;
    }
}