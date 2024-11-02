using UnityEditor;

namespace PHFramework.Editor
{
    static class PHFrameworkProjectSetting
    {
        [SettingsProvider]
        public static SettingsProvider PHFrameworkSetting()
        {
            var provider = new SettingsProvider("Project/PHFramework", SettingsScope.Project)
            {
                label = "PHFramwework",

            };
            return provider;
        }
    }
}