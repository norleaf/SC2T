using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starcraft2Turnbased
{
    public class Map : Tech
    {
        public  List<StartLocation> StartLocations;
        public Map(int w, int h, params StartLocation[] startLocations)
        {
            Width = w;
            Height = h;
            StartLocations = new List<StartLocation>();
            StartLocations.AddEach(startLocations);
        }

        public class StartLocation
        {
            public int x, y;

            public StartLocation(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }
}
