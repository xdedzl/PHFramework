using UnityEngine;
using UnityEngine.UI;

namespace PHFramework.UI
{
    [RequireComponent(typeof(ToggleGroup))]
    [AddComponentMenu("PHFramework/XToggleGroup")]
    public class PHToggleGroup : PHUIBase
    {
        public ToggleGroup toggleGroup;
        private void Reset()
        {
            toggleGroup = GetComponent<ToggleGroup>();
        }

        public void SetAllOff()
        {
            toggleGroup.SetAllTogglesOff();
        }
    }
}