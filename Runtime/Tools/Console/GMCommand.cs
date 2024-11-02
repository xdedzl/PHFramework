using System;
using UnityEngine;

namespace PHFramework.Console
{
    public abstract class GMCommandBase
    {
        public abstract int Order { get; }
        public abstract string TabName { get; }
    }

    public class XGMCommand : GMCommandBase
    {
        public override int Order => -1;

        public override string TabName => "";

        [GMCommand("clear")]
        public static void ClearConsole()
        {
            PHConsole.Clear();
        }

        [GMCommand("enable_hunter")]
        public static void StartHunter()
        {
            PHConsole.Log("�ѳɹ���Hunter");
            PHConsole.ConnetHunter();
        }

        [GMCommand("disable_hunter")]
        public static void StopHunter()
        {
            PHConsole.Log("�ѳɹ��ر�Hunter");
            PHConsole.DisConnetHunter();
        }

        [GMCommand("log")]
        public static void UnityLog(string content)
        {
            Debug.Log(content);
        }
    }

    [AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public class GMCommandAttribute : Attribute
    {
        public string cmd;
        public string name;
        public int order;
        public GMCommandAttribute(string cmd = null, string name = null, int order = -1)
        {
            this.cmd = cmd;
            this.name = name;
            this.order = order;
        }
    }
}