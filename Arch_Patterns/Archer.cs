using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch_Patterns
{
    internal class Archer : Unit
    {
        public Archer(int hitPoints, int attackPoints, int defencePoins, int specialAbilityStrength, int specialAbilityRange)
            : base(hitPoints, attackPoints, defencePoins, (-1) * specialAbilityStrength, specialAbilityRange, "Archer")
        {
        }
    }
}
