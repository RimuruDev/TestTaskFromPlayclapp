using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace RimuruDev.FromPlayclapp.MVC
{
    public sealed class InputFieldController
    {
        private InputFieldModel _inputFieldModel = null;

        private readonly string[] constText = { "Motion speed:", "Spawn cooldown:", "Max distance:" };

        public InputFieldController(InputFieldNode motionSpeed, InputFieldNode spawnCooldown, InputFieldNode distance)
        {
            _inputFieldModel = new(motionSpeed, spawnCooldown, distance);

            OnEnable();
        }

        ~InputFieldController() => OnDisable();

        private void OnEnable()
        {
            _inputFieldModel.motionSpeed.InputField.onEndEdit.AddListener(delegate
            {
                Input(_inputFieldModel.motionSpeed.InputField, _inputFieldModel.motionSpeed.Text, constText[0]);
            });

            _inputFieldModel.spawnCooldown.InputField.onEndEdit.AddListener(delegate
            {
                Input(_inputFieldModel.spawnCooldown.InputField, _inputFieldModel.spawnCooldown.Text, constText[1]);
            });

            _inputFieldModel.distance.InputField.onEndEdit.AddListener(delegate
            {
                Input(_inputFieldModel.distance.InputField, _inputFieldModel.distance.Text, constText[2]);
            });
        }

        private void OnDisable()
        {
            _inputFieldModel.motionSpeed.InputField.onEndEdit.RemoveListener(delegate
            {
                Input(_inputFieldModel.motionSpeed.InputField, _inputFieldModel.motionSpeed.Text, constText[0]);
            });

            _inputFieldModel.spawnCooldown.InputField.onEndEdit.RemoveListener(delegate
            {
                Input(_inputFieldModel.spawnCooldown.InputField, _inputFieldModel.spawnCooldown.Text, constText[1]);
            });

            _inputFieldModel.distance.InputField.onEndEdit.RemoveListener(delegate
            {
                Input(_inputFieldModel.distance.InputField, _inputFieldModel.distance.Text, constText[2]);
            });

            _inputFieldModel = null;
        }

        private void Input(TMP_InputField inputField, Text displayText, string text)
        {
            if (float.TryParse(inputField.text, out float result))
            {
                if (result < 0 || result > 1000)
                {
                    result = 0;
                    inputField.text = "0";
                }

                displayText.text = $"{text} {result}";
            }
            else
                Debug.Log($"TryParse is failure! Input: [{inputField.text}]");
        }
    }
}