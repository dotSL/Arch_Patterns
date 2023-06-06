using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch_Patterns
{
    internal class InfantryFabric : IUnitFabric
    {
        public Unit createUnit(int hitPoints,
            int attackPoints,
            int defencePoints,
            int specialAbilityStrength,
            int specialAbilityRange)
        {
            return new Infantry(hitPoints, attackPoints, defencePoints);
        }
    }
}
