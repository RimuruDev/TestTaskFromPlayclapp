using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace RimuruDev.FromPlayclapp
{
    public sealed class InputFieldView : MonoBehaviour
    {
        public StringEvent stringEventstringEvent;

        public List<StringEvent> InputFieldEnebtList;
        public List<TMP_InputField> InputFieldEnebtList2;

        public InputFieldController inputFieldController;
        public InputFieldView _inputFieldView;
        public InputFieldModel _inputFieldModel;

        // Bind low lewel
        public TMP_InputField _motionSpeedInputField;
        public TMP_InputField _spawnCooldownInputField;
        public TMP_InputField _maxDistanceInputField;

        private void Start()
        {
            _inputFieldModel = new(_motionSpeedInputField, _spawnCooldownInputField, _maxDistanceInputField);
            inputFieldController = new(_inputFieldModel);

            _inputFieldModel = new(InputFieldEnebtList);
        }

     //   private void Update() => inputFieldController.UpdateText();
    }
}