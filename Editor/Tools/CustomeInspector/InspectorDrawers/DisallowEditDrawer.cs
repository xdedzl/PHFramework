using UnityEditor;
using UnityEngine;

namespace PHFramework.Editor
{
    [CustomPropertyDrawer(typeof(DisallowEditAttribute))]
    public class DisallowEditDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginDisabledGroup(true);
            EditorGUI.PropertyField(position, property);
            EditorGUI.EndDisabledGroup();
        }
    }
}
