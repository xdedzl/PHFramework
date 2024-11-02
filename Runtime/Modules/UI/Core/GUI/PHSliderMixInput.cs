using UnityEngine;

namespace PHFramework.UI
{
    [RequireComponent(typeof(SliderMixInput))]
    [UnityEngine.AddComponentMenu("PHFramework/XSliderMixInput")]
    public class PHSliderMixInput : PHUIBase
    {
        public SliderMixInput mix;

        private void Reset()
        {
            mix = GetComponent<SliderMixInput>();
        }
    }
}