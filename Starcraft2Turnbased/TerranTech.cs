using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starcraft2Turnbased
{

    //public enum TerranTech
    //{
    //    Stimpack, CombatShield
    //}

    public class Stimpack : Upgrade
    {
        public Stimpack() : base(Upgrades.Stimpack)
        {
            Minerals = 100;
            Gas = 100;
            BuildTime = 100;
        }
        public override bool Available(Structure structure)
        {
            throw new NotImplementedException();
        }
    }
    //            Name = "Vehicle Weapons 1",
    //            Gas = 100,
    //            Minerals = 100 ,
    //            ResearchTime = 160,
    //            Prerequisites = new List<Upgrade> { }
    //        });

    //        list.Add(
    //        new Upgrade
    //        {
    //            Name = "Stimpack",
    //            Gas = 100,
    //            Minerals = 100,
    //            ResearchTime = 100
    //        });
}
