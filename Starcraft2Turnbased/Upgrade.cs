using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starcraft2Turnbased
{
public    class Upgrade
    {
        public bool Researched { get; set; }
        public int Minerals { get; set; }
        public int Gas { get; set; }
        
        public virtual bool Available() 
        {
            return true;
        }
    }
}
