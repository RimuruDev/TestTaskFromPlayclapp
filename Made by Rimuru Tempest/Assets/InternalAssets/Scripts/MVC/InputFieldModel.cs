using System.Collections.Generic;
using TMPro;

namespace RimuruDev.FromPlayclapp
{
    public sealed class InputFieldModel
    {
        public TMP_InputField _motionSpeedInputField = null;
        public TMP_InputField _spawnCooldownInputField = null;
        public TMP_InputField _maxDistanceInputField = null;

        public List<TMP_InputField> inputFieldList = null;

        public InputFieldModel(TMP_InputField motionSpeedInputField, TMP_InputField spawnCooldownInputField, TMP_InputField maxDistanceInputField)
        {
            this._motionSpeedInputField = motionSpeedInputField;
            this._spawnCooldownInputField = spawnCooldownInputField;
            this._maxDistanceInputField = maxDistanceInputField;

            inputFieldList = new()
            {
                _motionSpeedInputField,
                _spawnCooldownInputField,
                _maxDistanceInputField
            };
        }

        public List<StringEvent> stringEvents;

        public InputFieldModel(List<StringEvent> stringEvents)
        {
            foreach (var item in stringEvents)
            {
                this.stringEvents.Add(item);
            }
        }
    }
}