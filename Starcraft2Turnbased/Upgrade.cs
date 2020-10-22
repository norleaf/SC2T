using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Starcraft2Turnbased
{
    public abstract class Upgrade : Tech
    {
        public Upgrades Name { get; set; }
        protected Upgrade(Upgrades name)
        {
            Name = name;
        }

        //private bool researched;
        
        public bool Researched(Player player)
        {
            return player.UpgradesResearched.Any(x => x.Name == Name);
        }

        public abstract bool Available(Structure structure);
    }

    public enum Upgrades
    {
        Stimpack, CombatShield
    }

    //public class Barracks

    //public static class Upgrades
    //{
    //    public static List<Upgrade> CreateTerranList()
    //    {
    //        List<Upgrade> list = new List<Upgrade>();

    //        list.Add(
    //        new Upgrade
    //        {
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

    //        return list;
    //    }


    //}
}
