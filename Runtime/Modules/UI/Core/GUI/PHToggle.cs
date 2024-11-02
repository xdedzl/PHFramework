using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Events;

namespace PHFramework.UI
{
    [RequireComponent(typeof(Toggle))]
    [AddComponentMenu("PHFramework/XUToggle")]
    public class PHToggle : PHUIBase
    {
        public Toggle toggle;

        public void AddListener(UnityAction<bool> action)
        {
            toggle.onValueChanged.AddListener(action);
        }

        private void Reset()
        {
            this.toggle = GetComponent<Toggle>();
        }
    }
}