using UnityEngine.UI;
using UnityEngine.Events;

namespace PHFramework.UI
{
    [UnityEngine.RequireComponent(typeof(InputField))]
    [UnityEngine.AddComponentMenu("PHFramework/XInputField")]
    public class PHInputField : PHUIBase
    {
        public InputField inputField;

        private void Reset()
        {
            inputField = transform.GetComponent<InputField>();
        }

        public void AddOnEditorEnd(UnityAction<string> call)
        {
            inputField.onEndEdit.AddListener(call);
        }

        public void AddOnValidateInput(InputField.OnValidateInput call)
        {
            inputField.onValidateInput = call;
        }

        public void AddOnValueChanged(UnityAction<string> call)
        {
            inputField.onValueChanged.AddListener(call);
        }
    }
}