using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch_Patterns
{
    internal class Healer : Unit
    {
        public Healer(int hitPoints, int attackPoints, int defencePoins, int specialAbilityStrength, int specialAbilityRange)
            : base(hitPoints, attackPoints, defencePoins, specialAbilityStrength, specialAbilityRange, "Healer")
        {
        }
    }
}
