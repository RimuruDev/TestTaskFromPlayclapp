using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace RimuruDev.FromPlayclapp
{
    public sealed class BindingUI : MonoBehaviour
    {
        public List<InputFieldNode> inputFields;
    }

    [Serializable]
    public sealed class InputFieldNode
    {
        public TMP_InputField inputField;
        public Text text;
    }
}
