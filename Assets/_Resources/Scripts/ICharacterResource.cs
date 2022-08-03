using System;

namespace CharacterInfo
{
    public interface ICharacterResource
    {
        event Action OnSubtraction;
        event Action OnAddition;
        event Action OnEmpty;

        int LastResourceUsed { get; }
        int LastResourceAdded { get; }
        bool IsEmpty { get; }
        int MaxResource { get; }
        int CurrentResource { get; }

        void AddResource(int resourceAmount);
        void SubtractResource(int resourceAmount);
        void ResetResource();
        void SetMaxResource(int resourceAmount);
    }
}