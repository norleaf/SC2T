using System.Collections.Generic;

namespace Starcraft2Turnbased
{
    public class Structure : Visible
    {
        public static List<Upgrade> Upgrades { get; set; }
        public List<Unit> Units { get; set; }
        public virtual bool functional()
        {
            return true;
        }
    }
}