using UnityEngine.UI;
using UnityEngine;

namespace PHFramework.UI
{
    [RequireComponent(typeof(Scrollbar))]
    [UnityEngine.AddComponentMenu("PHFramework/XScrollbar")]
    public class PHScrollbar : PHUIBase
    {
        public Scrollbar scrollbar;

        private void Reset()
        {
            scrollbar = GetComponent<Scrollbar>();
        }

        public void AddListener(UnityEngine.Events.UnityAction<float> call)
        {
            scrollbar.onValueChanged.AddListener(call);
        }
    }
}
