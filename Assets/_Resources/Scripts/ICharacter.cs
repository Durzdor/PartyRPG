namespace CharacterInfo
{
    public interface ICharacter
    {
        BaseCharacterStatistics BaseCharacterStatistics { get; }
        Health Health { get; }
        void CalculateMaxHealth();
        int MinHealth { get; }
    }
}
