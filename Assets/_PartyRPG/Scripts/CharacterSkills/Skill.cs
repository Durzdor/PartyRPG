
using CharacterInfo;
using UnityEngine;

namespace CharacterSkill
{
    public abstract class Skill : MonoBehaviour, ISkill
    {
        public int CooldownRemaining { get; private set; }
        
        protected BaseSkillStatistics SkillStatistics;

        public int SkillFinalDamage { get; protected set; }
        public BaseSkillStatistics BaseSkillStatistics => SkillStatistics;
        public bool IsOffCooldown { get; private set; } = true;
        
        public virtual void UseSkill(BaseCharacterStatistics baseCharacterStatistics)
        {
            if (!IsOffCooldown) return;
            IsOffCooldown = false;
            CooldownRemaining = BaseSkillStatistics.SkillCooldown;
        }

        public void UpdateCooldown()
        {
            if (CooldownRemaining > 0)
            {
                CooldownRemaining--;
                if (CooldownRemaining <= 0)
                {
                    IsOffCooldown = true;
                }
            }
            else
            {
                IsOffCooldown = true;
            }
        }
    }
}
