using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch_Patterns
{
    internal class HeavyInfantryFabric : IUnitFabric
    {
        public Unit createUnit(int hitPoints,
            int attackPoints,
            int defencePoints,
            int specialAbilityStrength,
            int specialAbilityRange)
        {
            return new HeavyInfantry(hitPoints, attackPoints, defencePoints);
        }
    }
}
