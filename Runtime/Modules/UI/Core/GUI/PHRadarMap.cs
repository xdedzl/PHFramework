using UnityEngine;

namespace PHFramework.UI
{
    [RequireComponent(typeof(RadarMap))]
    public class PHRadarMap : PHUIBase
    {
        public RadarMap radarMap;

        private void Reset()
        {
            radarMap = transform.GetComponent<RadarMap>();
        }
    }
}