using UnityEngine;

namespace CharacterInfo
{
    public abstract class BaseCharacter : MonoBehaviour, ICharacter
    {
        public BaseCharacterStatistics BaseCharacterStatistics { get; protected set; }
        public BaseCharacterResources BaseCharacterResources { get; private set; }


        protected void Awake()
        {
            BaseCharacterResources = GetComponent<BaseCharacterResources>();
        }
    }
}
