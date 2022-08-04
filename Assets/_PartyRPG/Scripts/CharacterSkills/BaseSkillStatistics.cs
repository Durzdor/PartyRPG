using GlobalMechanics;
using UnityEngine;

namespace CharacterSkill
{
    [CreateAssetMenu(fileName = "New Character", menuName = "Character/Base Skill", order = 51)]
    public class BaseSkillStatistics : ScriptableObject
    {
        [SerializeField] private string skillName = "Skill Name";
        [SerializeField] private int baseDamage = 1;
        [SerializeField] private int skillCost = 0;
        [SerializeField] private int skillCooldown = 0;
        [SerializeField] private AttributeDesignation attribute = AttributeDesignation.Strength;
        [SerializeField] private DamageType damageType = DamageType.Physical;
        
        public string SkillName => skillName;
        public int BaseDamage => baseDamage;
        public int SkillCost => skillCost;
        public int SkillCooldown => skillCooldown;
        public AttributeDesignation Attribute => attribute;
        public DamageType Type => damageType;
    }
}