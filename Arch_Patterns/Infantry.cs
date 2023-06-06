using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch_Patterns
{
    internal class Infantry : Unit
    {
        public Infantry(int hitPoints, int attackPoints, int defencePoins) 
            : base(hitPoints, attackPoints, defencePoins, 0, 0, "Infantry")
        {
        }
    }
}
