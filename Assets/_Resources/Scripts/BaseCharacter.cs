using GlobalMechanics;
using UnityEngine;

namespace CharacterInfo
{
    public abstract class BaseCharacter : MonoBehaviour, ICharacter
    {
        private BaseCharacterStatistics _baseCharacterStatistics;
        protected Health _health;
        protected int _minHealth;
        public BaseCharacterStatistics BaseCharacterStatistics => _baseCharacterStatistics;
        public Health Health => _health;
        public int MinHealth => _minHealth;
        
        public virtual void CalculateMaxHealth()
        {
            var maxHp = (_baseCharacterStatistics.Constitution * (int)HealthAttributeModifier.ConstitutionMod) + 
                           (_baseCharacterStatistics.Strength * (int)HealthAttributeModifier.StrengthMod) + 
                           _minHealth;
            _health.SetMaxHealth(maxHp);
        }
    }
}
