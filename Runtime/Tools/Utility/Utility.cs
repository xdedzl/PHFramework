// ==========================================
// 描述： 
// 作者： HAK
// 时间： 2018-10-24 16:26:10
// 版本： V 1.0
// ==========================================
using System.Collections.Generic;
using UnityEngine;
using System;

namespace PHFramework
{
    /// <summary>
    /// 使用工具类
    /// </summary>
    public static partial class UUtility
    {
        /// <summary>
        /// 发射射线并返回RaycastInfo
        /// </summary>
        public static bool SendRay(out RaycastHit raycastHit, int layer = -1)
        {
            return Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, float.MaxValue, layer);
        }
        public static bool SendRayDown(Vector3 start, out RaycastHit raycastHit, int layer = -1)
        {
            start.y += 10000;
            return Physics.Raycast(start, Vector3.down, out raycastHit, float.MaxValue, layer);
        }

        /// <summary>
        /// 创建立方体
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static GameObject CreatPrimitiveType(PrimitiveType type, Vector3 pos = default, float size = 1)
        {
            GameObject obj = GameObject.CreatePrimitive(type);
            obj.transform.position = pos;
            obj.transform.localScale = Vector3.one * size;
            return obj;
        }
        public static GameObject CreatPrimitiveType(PrimitiveType type, Color color, Vector3 pos = default, float size = 1)
        {
            GameObject obj = CreatPrimitiveType(type, pos, size);
            obj.GetComponent<MeshRenderer>().material.color = color;
            return obj;
        }

        /// <summary>
        /// 获取一组位置
        /// </summary>
        public static Vector3[] GetPositions(IList<Transform> trans)
        {
            Vector3[] poses = new Vector3[trans.Count];
            for (int i = 0, length = trans.Count; i < length; i++)
            {
                poses[i] = trans[i].position;
            }
            return poses;
        }

        /// <summary>
        /// 获取一组欧拉角
        /// </summary>
        public static Vector3[] GetAngles(IList<Transform> trans)
        {
            Vector3[] angles = new Vector3[trans.Count];
            for (int i = 0, length = trans.Count; i < length; i++)
            {
                angles[i] = trans[i].localEulerAngles;
            }
            return angles;
        }

        /// <summary>
        /// 打印一个方法的执行时间
        /// </summary>
        /// <param name="action"></param>
        /// <param name="format">控制台输出格式</param>
        public static void DebugActionRuntime(Action action, string format = null)
        {
            float time = Utility.Time.GetActionRunTime(action);
            if (string.IsNullOrEmpty(format))
            {
                format = "{0}";
            }
            Debug.Log(string.Format(format, time));
        }
    }
}