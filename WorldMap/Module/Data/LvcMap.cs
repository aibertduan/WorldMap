using System.Collections.Generic;

namespace WorldMap.Module.Data
{
    public class LvcMap
    {
        public double DesiredWidth { get; set; }
        public double DesiredHeight { get; set; }
        public List<MapData> Data { get; set; }
    }
}