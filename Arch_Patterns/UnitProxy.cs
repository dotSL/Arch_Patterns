using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch_Patterns
{
    internal class UnitProxy
    {
        private Unit _unit;
        private Logger _logger;

        public UnitProxy(Unit unit, string filePath)
        {
            _unit = unit;
            _logger = new Logger(_unit, filePath);
        }

        public void ApplyDamage(int damage)
        {
            _logger.log(damage);
            _unit.ApplyDamage(damage);
        }
    }
}
