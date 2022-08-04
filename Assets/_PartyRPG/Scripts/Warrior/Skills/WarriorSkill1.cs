using CharacterInfo;
using GlobalMechanics;
using UnityEngine;

namespace CharacterSkill
{
    public class WarriorSkill1 : Skill
    {
        [SerializeField] private BaseSkillStatistics baseSkillStatistics;

        private void Awake()
        {
            SkillStatistics = baseSkillStatistics;
        }

        public override void UseSkill(BaseCharacterStatistics baseCharacterStatistics)
        {
            base.UseSkill(baseCharacterStatistics);
            
            var attributeDamageModifier = baseSkillStatistics.Attribute switch
            {
                AttributeDesignation.Strength => baseCharacterStatistics.Strength,
                AttributeDesignation.Dexterity => baseCharacterStatistics.Dexterity,
                AttributeDesignation.Intelligence => baseCharacterStatistics.Intelligence,
                _ => 0
            };
            var baseDamageModifier = baseSkillStatistics.BaseDamage;
            SkillFinalDamage = attributeDamageModifier + baseDamageModifier;
            
            print("Warrior1 Skill" + SkillFinalDamage);
        }
    }
}