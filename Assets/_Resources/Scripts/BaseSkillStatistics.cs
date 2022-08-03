using GlobalMechanics;
using UnityEngine;

namespace CharacterSkill
{
    [CreateAssetMenu(fileName = "New Character", menuName = "Character/Base Skill", order = 51)]
    public class BaseSkillStatistics : ScriptableObject
    {
        [SerializeField] private string skillName;
        [SerializeField] private int baseDamage;
        [SerializeField] private int skillCost;
        [SerializeField] private AttributeDesignation attribute;
        [SerializeField] private DamageType damageType;
        
        public string SkillName => skillName;
        public int BaseDamage => baseDamage;
        public int SkillCost => skillCost;
        public AttributeDesignation Attribute => attribute;
        public DamageType Type => damageType;
    }
}