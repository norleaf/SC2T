using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starcraft2Turnbased
{
    public class Player : Visible
    {
        public int Minerals { get; set; }
        public int Gas { get; set; }
        public List<Unit> Units { get; set; }
        public List<Structure> Structures { get; set; }
    }
}
