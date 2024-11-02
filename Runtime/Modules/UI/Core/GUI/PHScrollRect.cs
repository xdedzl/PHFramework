using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine;

namespace PHFramework.UI
{
    [RequireComponent(typeof(ScrollRect))]
    [UnityEngine.AddComponentMenu("PHFramework/XScrollRect")]
    public class PHScrollRect : PHUIBase
    {
        public ScrollRect scrollRect;

        private void Reset()
        {
            scrollRect = GetComponent<ScrollRect>();
        }

        public void AddOnValueChanged(UnityAction<Vector2> call)
        {
            scrollRect.onValueChanged.AddListener(call);
        }
    }
}