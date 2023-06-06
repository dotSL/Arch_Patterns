using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch_Patterns
{
    internal class HealerFactory : IUnitFabric
    {
        public Unit createUnit(int hitPoints, int attackPoints, int defencePoints, int specialAbilityStrength, int specialAbilityRange)
        {
            return new Healer(hitPoints, attackPoints, defencePoints, specialAbilityStrength, specialAbilityRange);
        }
    }
}
