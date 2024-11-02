using UnityEngine;

namespace PHFramework.UI
{
    /// <summary>
    /// 仅用于实现 Tree 的查找
    /// </summary>
    [RequireComponent(typeof(ShapeGraphic))]
    public class PHShapeGraphic : PHUIBase
    {
        /// <summary>
        /// Tree 实体
        /// </summary>
        public ShapeGraphic shapeGraphic;
        private void Reset()
        {
            shapeGraphic = transform.GetComponent<ShapeGraphic>();
        }
    }
}