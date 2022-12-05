namespace RimuruDev.FromPlayclapp
{
    public sealed class InputFieldController
    {
        public InputFieldModel _inputFieldModel = null;

        public InputFieldController(InputFieldModel inputFieldModel)
        {
            _inputFieldModel = inputFieldModel;

            OnEnable();
        }

        private void OnEnable()
        {
            _inputFieldModel._spawnCooldownInputField.onValueChanged.AddListener(delegate { ValidateData(); });
            _inputFieldModel._maxDistanceInputField.onValueChanged.AddListener(delegate { ValidateData(); });
            _inputFieldModel._motionSpeedInputField.onValueChanged.AddListener(delegate { ValidateData(); });
        }

        private void OnDisable()
        {
            _inputFieldModel._spawnCooldownInputField.onValueChanged.RemoveAllListeners();
            _inputFieldModel._maxDistanceInputField.onValueChanged.RemoveAllListeners();
            _inputFieldModel._motionSpeedInputField.onValueChanged.RemoveAllListeners();
        }

        // ~InputFieldController() => OnDisable();

        public void UpdateText()
        {

        }

        public void ValidateData()
        {
//
          //  for (int i = 0; i < _inputFieldModel.stringEvents.Count; i++)
        //    {
                // _inputFieldModel.stringEvents[i].AddListener(delegate
                // {
                //_inputFieldModel.stringEvents[i].
                //});
           // }

            /*
            foreach (var inputField in _inputFieldModel.inputFieldList)
            {
                if (float.TryParse(inputField.text, out var result))
                {
                    if (result < 0 || result > 1000) result = 0;


                }
            }*/
            /*
            float previousValue = dataContainer.GetGameplaySettings.MotionSpeed;

            if (float.TryParse(dataContainer.InputFielContainer.MotionSpeedInputField.text, out float result))
            {
                if (result < 0) result = previousValue;
                if (result == 0) result = 0.01f;
                if (result >= ushort.MaxValue / 2) result = previousValue;

                dataContainer.GetGameplaySettings.MotionSpeed = result;
                dataContainer.TextContainer.MotionSpeedText.text = $"Motion speed: {dataContainer.GetGameplaySettings.MotionSpeed}";
            }*/
        }
    }
}