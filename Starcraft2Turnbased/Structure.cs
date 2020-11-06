using System.Collections.Generic;
using System.Linq;

namespace Starcraft2Turnbased
{
    public abstract class Structure : Tech
    {
        public List<Upgrade> Upgrades { get; set; }
        public List<Tech> Units { get; set; }
        public Queue<Tech> BuildQueue { get; set; }

        public abstract bool Available(Player player);

        public Structure() : base()
        {
            Units = new List<Tech>();
            Upgrades = new List<Upgrade>();
            Attributes.Add(Keywords.Structure);
            BuildQueue = new Queue<Tech>();
        }

        public bool Enqueue(Player player, Tech unit)
        {
            bool supplyAvailable = player.SupplyUsed() + unit.Supply <= player.SupplyMax();
            bool hasResources = player.Minerals >= unit.Minerals && player.Gas >= unit.Gas;
            if (supplyAvailable && hasResources)
            {
                player.Minerals -= unit.Minerals;
                player.Gas -= unit.Gas;
                BuildQueue.Enqueue(unit);
                return true;
            }
            return false;
        }
    }
}


namespace Starcraft2Turnbased
{

    public class Armory : Structure
    {
        public Armory()
        {
            HP = HPMax = 750;
            Armor = 1; BuildTime = 46;
            Attributes.AddEach(Keywords.Armored, Keywords.Mechanical);
            //Upgrades.Add(VehicleWeapons1)
        }

        public override bool Available(Player player)
        {
            return player.Structures.Any(x => x.GetType() == typeof(Factory));
        }
    }

    public class Supply_Depot : Structure
    {
        public Supply_Depot()
        {
            HP = HPMax = 400;
            Armor = 1; BuildTime = 21;
            Attributes.AddEach(Keywords.Armored, Keywords.Mechanical);

        }
        public override bool Available(Player player)
        {
            return true;
        }
    }

    public class Barracks : Structure
    {
        public Barracks() 
        {
            HP = HPMax = 1000;
        }

        public override bool Available(Player player)
        {
           return player.Structures.Any(x => x.GetType() == typeof(Supply_Depot));
        }

        
    }

    public class Command_Center : Structure
    {
        public Command_Center() 
        {
            HP = HPMax = 1500;
            Armor = 1; 
            Minerals = 400; BuildTime = 71;
            Units.Add(new SCV());
        }

        public override bool Available(Player player)
        {
            return true;
        }
    }

    public class Factory : Structure
    {
        public Factory() 
        {
            HP = HPMax = 1250;
        }

        public override bool Available(Player player)
        {
            return player.Structures.Any(x => x.GetType() == typeof(Barracks));
        }
    }


}
