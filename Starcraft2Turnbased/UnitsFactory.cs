using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starcraft2Turnbased
{
    public class UnitsFactory
    {
        public SCV SCV;
        public Marine Marine;
        public Siege_Tank_Tank_Mode Siege_Tank_Tank_Mode;
        public Siege_Tank_Siege_Mode Siege_Tank_Siege_Mode;

        public UnitsFactory()
        {
            Marine = new Marine();
        }
    }

    
   
}
