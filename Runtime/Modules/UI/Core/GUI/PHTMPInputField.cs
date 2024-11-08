﻿using TMPro;
using UnityEngine.Events;

namespace PHFramework.UI
{
    [UnityEngine.RequireComponent(typeof(TMP_InputField))]
    public class PHTMPInputField : PHUIBase
    {
        public TMP_InputField inputField;

        private void Reset()
        {
            inputField = transform.GetComponent<TMP_InputField>();
        }

        public void AddOnEditorEnd(UnityAction<string> call)
        {
            inputField.onEndEdit.AddListener(call);
        }

        public void AddOnValidateInput(TMP_InputField.OnValidateInput call)
        {
            inputField.onValidateInput = call;
        }

        public void AddOnValueChanged(UnityAction<string> call)
        {
            inputField.onValueChanged.AddListener(call);
        }
    }
}