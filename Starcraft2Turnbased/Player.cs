using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starcraft2Turnbased
{
    public class Player : Visible
    {

        public List<Unit> Units { get; set; }
        public List<Structure> Structures { get; set; }
    }
}
