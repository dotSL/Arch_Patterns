using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch_Patterns
{
    internal class HeavyInfantry : Unit
    {
        public HeavyInfantry(int hitPoints, int attackPoints, int defencePoins)
            : base(hitPoints, attackPoints, defencePoins, 0, 0, "Heavy Infantry")
        {
        }
    }
}
