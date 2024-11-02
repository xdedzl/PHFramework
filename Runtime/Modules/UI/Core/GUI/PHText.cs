using UnityEngine.UI;

namespace PHFramework.UI
{
    [UnityEngine.RequireComponent(typeof(Text))]
    [UnityEngine.AddComponentMenu("PHFramework/XText")]
    public class PHText : PHUIBase
    {
        public Text text;
        private void Reset()
        {
            text = transform.GetComponent<Text>();
        }
    }
}