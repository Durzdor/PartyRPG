using CharacterInfo;
using CharacterSkill;
using GlobalMechanics;
using UnityEngine;

public class DeveloperTools : MonoBehaviour
{
    [SerializeField] private BaseCharacter baseCharacter;
    [SerializeField] private Skill warrior1;
    
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            baseCharacter.BaseCharacterResources.TakeDamage(15, DamageType.Physical);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            warrior1.UseSkill(baseCharacter.BaseCharacterStatistics);
        }
    }
}
