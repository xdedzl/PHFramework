using UnityEngine;
using UnityEngine.UI;

namespace PHFramework.UI
{
    [RequireComponent(typeof(RawImage))]
    public class PHRawImage : PHUIBase
    {
        public RawImage image;

        private void Reset()
        {
            image = GetComponent<RawImage>();
        }
    }
}