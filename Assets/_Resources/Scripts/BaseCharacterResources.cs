using System;
using GlobalMechanics;
using UnityEngine;

namespace CharacterInfo
{
    public class BaseCharacterResources : MonoBehaviour
    {
        private BaseCharacter _baseCharacter;
        private LifeController _lifeController;

        private void Awake()
        {
            _baseCharacter = GetComponent<BaseCharacter>();
            _lifeController = GetComponent<LifeController>();
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
    }
}