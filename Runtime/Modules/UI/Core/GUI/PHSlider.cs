using UnityEngine;
using UnityEngine.UI;

namespace PHFramework.UI
{
    [RequireComponent(typeof(Slider))]
    [UnityEngine.AddComponentMenu("PHFramework/XSlider")]
    public class PHSlider : PHUIBase
    {
        public Slider slider;

        private void Reset()
        {
            slider = GetComponent<Slider>();
        }

        public void AddListener(UnityEngine.Events.UnityAction<float> call)
        {
            slider.onValueChanged.AddListener(call);
        }
    }
}