using UnityEngine;
using UnityEngine.Events;

namespace PHFramework.UI
{
    [RequireComponent(typeof(LongOrDoubleBtn))]
    [UnityEngine.AddComponentMenu("PHFramework/GULongOrDoubleBtn")]
    public class PHLongOrDoubleBtn : PHUIBase
    {
        public LongOrDoubleBtn longOrDoubleBtn;

        private void Reset()
        {
            longOrDoubleBtn = GetComponent<LongOrDoubleBtn>();
        }

        public void AddOnLongClick(UnityAction<float> call)
        {
            longOrDoubleBtn.onLongClick.AddListener(call);
        }

        public void AddOnDoubleClick(UnityAction call)
        {
            longOrDoubleBtn.onDoubleClick.AddListener(call);
        }
    }
}