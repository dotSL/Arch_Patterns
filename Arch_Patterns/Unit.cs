using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch_Patterns
{
    internal abstract class Unit 
    {
        private int _hitPoints;
        private int _attackPoints;
        private int _defencePoints;
        private int _specialAbilityStrength;
        private int _specialAbilityRange;
        string _name;

        protected Unit(int hitPoints,
            int attackPoints,
            int defencePoints,
            int specialAbilityStrength,
            int specialAbilityRange,
            string name)
        {
            _hitPoints = hitPoints;
            _attackPoints = attackPoints;
            _defencePoints = defencePoints;
            _specialAbilityStrength = specialAbilityStrength;
            _specialAbilityRange = specialAbilityRange;
            _name = name;
        }

        public void ApplyDamage(int damage)
        {
            if (_defencePoints < damage)
                _hitPoints -= damage - _defencePoints;
        }

        public void ApplySpecialAbilityImpact(int specialAbilityImpact)
        {
            if (specialAbilityImpact < 0)
                ApplyDamage((-1) * specialAbilityImpact);
            else
                _hitPoints += specialAbilityImpact;

        }
        public bool IsAlive()
        {
            return _hitPoints > 0;
        }

        public string Name { get { return _name; } }
        public int AttackPoints { get { return _attackPoints; } }
        public int SpecialAbilityStrength { get { return _specialAbilityStrength; } }
        public int DefencePoints { get { return _defencePoints; } }
    }
}
