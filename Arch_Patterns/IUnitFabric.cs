using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch_Patterns
{
    internal interface IUnitFabric
    {
        Unit createUnit(int hitPoints,
            int attackPoints,
            int defencePoints,
            int specialAbilityStrength,
            int specialAbilityRange);
    }
}
