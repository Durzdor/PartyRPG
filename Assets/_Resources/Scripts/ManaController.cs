using System;
using UnityEngine;

namespace CharacterInfo
{
    public class ManaController : MonoBehaviour, ICharacterResource
    {
        public event Action OnSubtraction;
        public event Action OnAddition;
        public event Action OnEmpty;
        public int LastResourceUsed { get; private set; }
        public int LastResourceAdded { get; private set; }
        public bool IsEmpty { get; private set; }
        public int MaxResource { get; private set; }
        public int CurrentResource { get; private set; }

        public void AddResource(int resourceAmount)
        {
            var resourceBefore = CurrentResource;
            CurrentResource += resourceAmount;
            CurrentResource = Math.Clamp(CurrentResource, 0, MaxResource);

            LastResourceAdded = CurrentResource - resourceBefore;
            if (LastResourceAdded > 0) OnAddition?.Invoke();
        }

        public void SubtractResource(int resourceAmount)
        {
            if (IsEmpty) return;
            var resourceBefore = CurrentResource;
            CurrentResource -= resourceAmount;
            CurrentResource = Math.Clamp(CurrentResource, 0, MaxResource);

            LastResourceUsed = resourceBefore - CurrentResource;
            if (LastResourceUsed > 0) OnSubtraction?.Invoke();

            HandleEmpty();
        }

        private void HandleEmpty()
        {
            if (IsEmpty) return;
            if (CurrentResource > 0) return;
            IsEmpty = true;
            OnEmpty?.Invoke();
        }

        public void ResetResource()
        {
            AddResource(MaxResource);
            IsEmpty = false;
        }

        public void SetMaxResource(int resourceAmount)
        {
            MaxResource = resourceAmount;
        }
    }
}