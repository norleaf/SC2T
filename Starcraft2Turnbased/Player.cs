using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starcraft2Turnbased
{
    public abstract class Player : Tech
    {
        public UnitsFactory UnitsFactory { get; set; }
        public List<Tech> Units { get; set; }
        public List<Structure> Structures { get; set; }
        public List<Upgrade> UpgradesResearched { get; set; }
   //     public List<Upgrade> UpgradesAvailable { get; set; }

        public int SupplyUsed()
        {
            return Units.Sum(x => x.Supply) + Structures.Sum(x => x.BuildQueue.Sum(q=>q.Supply));
            
        }

        public int SupplyMax()
        {
            int maxSupply = Structures.Sum((x => x.Supply));
            
            return maxSupply <= 200 ? maxSupply : 200;
        }

        public Player() : base()
        {
            Minerals = 50;
            Units = new List<Tech>();
            Structures = new List<Structure>();
            UpgradesResearched = new List<Upgrade>();
           
        }
    }

    public class Terran : Player
    {
        public Terran() : base()
        {
            Structures.Add(new Command_Center());
        }
    }

    public class Zerg : Player
    {
        public Zerg() : base()
        {
          
        }
    }

    public class Protoss : Player
    {
        public Protoss() : base()
        {
           
        }
    }
}
