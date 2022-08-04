
using CharacterInfo;

namespace CharacterSkill
{
    public interface ISkill
    {
        int SkillFinalDamage { get; }
        BaseSkillStatistics BaseSkillStatistics { get; }
        bool IsOffCooldown { get; }
        void UseSkill(BaseCharacterStatistics baseCharacterStatistics);
        void UpdateCooldown();
    }
}
