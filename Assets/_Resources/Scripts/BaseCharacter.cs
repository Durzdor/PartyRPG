using GlobalMechanics;
using UnityEngine;

namespace CharacterInfo
{
    public abstract class BaseCharacter : MonoBehaviour, ICharacter
    {
        protected BaseCharacterStatistics _baseCharacterStatistics;
        protected Health _health;
        public BaseCharacterStatistics BaseCharacterStatistics => _baseCharacterStatistics;
        public Health Health => _health;

        protected void Awake()
        {
            _health = GetComponent<Health>();
        }

        public void CalculateMaxHealth()
        {
            var maxHp = (_baseCharacterStatistics.Constitution * (int)HealthAttributeModifier.ConstitutionMod) + 
                           (_baseCharacterStatistics.Strength * (int)HealthAttributeModifier.StrengthMod) + 
                           _baseCharacterStatistics.BaseHealth;
            _health.SetMaxHealth(maxHp);
        }
        
        
    }
}
