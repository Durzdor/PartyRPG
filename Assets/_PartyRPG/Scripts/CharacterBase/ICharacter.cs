namespace CharacterInfo
{
    public interface ICharacter
    {
        BaseCharacterStatistics BaseCharacterStatistics { get; }
        BaseCharacterResources BaseCharacterResources { get; }
    }
}
