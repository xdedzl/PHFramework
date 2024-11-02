using System.Collections.Generic;
using PHFramework.Mathematics;
using UnityEngine;

namespace PHFramework.UI
{
    /// <summary>
    /// 椭圆绘制类
    /// </summary>
    public class EllipseGraphic : LineGraphic
    {
        public EllipseGraphic(Vector2 center, Vector2 radius)
        {
            var points = Math2d.GetEllipsePoints(radius.x, radius.y, center, 60);

            m_Poses = new List<Vector3>();
            foreach (var item in points)
            {
                m_Poses.Add(item);
            }
        }
    }
}