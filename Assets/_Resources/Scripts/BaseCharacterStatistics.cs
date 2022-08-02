namespace CharacterInfo
{
    using UnityEngine;
    
    [CreateAssetMenu(fileName = "New Character", menuName = "Character/Base Stats", order = 51)]
    public class BaseCharacterStatistics : ScriptableObject
    {
         [SerializeField] private int level = 1;
         [SerializeField] private int strength = 1;
         [SerializeField] private int dexterity = 1;
         [SerializeField] private int constitution = 1;
         [SerializeField] private int intelligence = 1;
         [SerializeField] private int armor = 1;
         [SerializeField] private int magicResist = 1;

         public int Level => level;
         public int Strength => strength;
         public int Dexterity => dexterity;
         public int Constitution => constitution;
         public int Intelligence => intelligence;
         public int Armor => armor;
         public int MagicResist => magicResist;
    }
}
