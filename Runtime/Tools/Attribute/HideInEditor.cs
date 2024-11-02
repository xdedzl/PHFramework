using System;

namespace PHFramework
{
    [AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
    public class HideInEditor : Attribute { }
}