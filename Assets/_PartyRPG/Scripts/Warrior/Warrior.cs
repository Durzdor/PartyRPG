using UnityEngine;

namespace CharacterInfo
{
    public class Warrior : BaseCharacter
    {
        [SerializeField] private BaseCharacterStatistics warriorBaseCharacterStatistics;

        private new void Awake()
        {
            base.Awake();
            BaseCharacterStatistics = warriorBaseCharacterStatistics;
        }
    }
}