using UnityEngine;

namespace PHFramework.UI
{
    [UnityEngine.RequireComponent(typeof(LineChart))]
    public class PHLineChat : PHUIBase
    {
        public LineChart lineChat;

        private void Reset()
        {
            lineChat = transform.GetComponent<LineChart>();
        }
    }
}