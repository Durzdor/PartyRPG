using System.Collections.Generic;
using CharacterInfo;
using UnityEngine;

namespace CharacterSkill
{
    
    public class BaseCharacterSkills : MonoBehaviour
    {
        [SerializeField] private GameObject skillContainer;
        private List<BaseCharacter> _skillList;
        private BaseCharacterResources _baseCharacterResources;
        private BaseCharacter _baseCharacter;

        private void Start()
        {
            _baseCharacter = GetComponent<BaseCharacter>();
            _baseCharacterResources = GetComponent<BaseCharacterResources>();
            _skillList = new List<BaseCharacter>(skillContainer.GetComponents<BaseCharacter>());
        }
    }
    
}
