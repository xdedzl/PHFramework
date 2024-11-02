using UnityEngine;

namespace PHFramework.UI
{
    [RequireComponent(typeof(CanvasGroup))]

    public class PHCanvasGroup : PHUIBase
    {
        public CanvasGroup canvasGroup;

        private void Reset()
        {
            canvasGroup = GetComponent<CanvasGroup>();
        }
    }
}