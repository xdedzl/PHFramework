using UnityEngine;

namespace PHFramework.UI
{
    [UnityEngine.RequireComponent(typeof(UnityEngine.UI.Image))]
    [UnityEngine.AddComponentMenu("PHFramework/XImage")]
    public class PHImage : PHUIBase
    {
        public UnityEngine.UI.Image image;

        private void Reset()
        {
            image = transform.GetComponent<UnityEngine.UI.Image>();
        }
    }
}