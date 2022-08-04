using GlobalMechanics;
using UnityEngine;

namespace CharacterInfo
{
    public class BaseCharacterResources : MonoBehaviour
    {
        private BaseCharacter _baseCharacter;
        private LifeController _lifeController;

        private void Start()
        {
            _baseCharacter = GetComponent<BaseCharacter>();
            _lifeController = GetComponent<LifeController>();
            _lifeController.OnAddition += Print;
            _lifeController.OnSubtraction += Print;
            
            CalculateMaxHealth();
        }

        public void Print()
        {
            print(_lifeController.CurrentResource);
        }

        public void TakeDamage(int damage, DamageType damageType)
        {
            var damageBefore = damage;
            var defenseAmount = damageType switch
            {
                DamageType.Physical => _baseCharacter.BaseCharacterStatistics.Armor,
                DamageType.Magical => _baseCharacter.BaseCharacterStatistics.MagicResist,
                _ => 0
            };
            var damageAfter = damage - defenseAmount;
            if (damageAfter <= 0) return;
            
            _lifeController.SubtractResource(damageAfter);
        }
        
        private void CalculateMaxHealth()
        {
            var maxHp = (_baseCharacter.BaseCharacterStatistics.Constitution * (int)HealthAttributeModifier.ConstitutionMod) + 
                        (_baseCharacter.BaseCharacterStatistics.Strength * (int)HealthAttributeModifier.StrengthMod) + 
                        _baseCharacter.BaseCharacterStatistics.BaseHealth;
            
            _lifeController.SetMaxResource(maxHp);
        }
    }
}