using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starcraft2Turnbased
{
    
}


namespace Starcraft2Turnbased
{
    //TODO: Prototypes

 

    public class Marine : Tech
    {
        public Marine() : base(
            buildTime: 18,
            supply:1,
            hP:45,
            hPMax:45,
            armor:0,
            move:3.15,
            sightRange:9,
            minerals:50,
            gas:0,
            ground:new Attack(0.61,5,6),
            air:new Attack(0.61,5,6),
            attributes: ListWords(Keywords.Light,Keywords.Biological),
            height:0,
            width: 0)
        {
        }
    }

    public class SCV : Tech
    {
        public SCV() : base(
            buildTime: 12,
            supply: 1,
            hP: 45,
            hPMax: 45,
            armor: 0,
            move: 3.94,
            sightRange: 8,
            minerals: 50,
            gas: 0,
            ground: new Attack(1.07,1,5),
            air: null,
            attributes: ListWords(Keywords.Biological,Keywords.Mechanical,Keywords.Light),
            height: 0,
            width: 0)
        {
        }
    }

    public class Siege_Tank_Siege_Mode : Tech
    {
        public Siege_Tank_Siege_Mode(UnitsFactory factory) : base(factory.Siege_Tank_Siege_Mode)
        {
        }
    }

    public class Siege_Tank_Tank_Mode : Tech
    {
        public Siege_Tank_Tank_Mode(UnitsFactory factory) : base(factory.Siege_Tank_Tank_Mode)
        {
        }
    }
}
