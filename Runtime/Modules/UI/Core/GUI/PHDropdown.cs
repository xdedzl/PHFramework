
namespace PHFramework.UI
{
    [UnityEngine.RequireComponent(typeof(UnityEngine.UI.Dropdown))]
    [UnityEngine.AddComponentMenu("PHFramework/GUDropdown")]
    public class PHDropdown : PHUIBase
    {
        public UnityEngine.UI.Dropdown dropdown;
        private void Reset()
        {
            dropdown = transform.GetComponent<UnityEngine.UI.Dropdown>();
        }

        public void AddListener(UnityEngine.Events.UnityAction<int> call)
        {
            dropdown.onValueChanged.AddListener(call);
        }
    }
}