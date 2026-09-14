namespace VerfluchterDungeon
{
    /// <summary>Vertrag für alles, was einen Angriff ausführen kann.</summary>
    public interface IAttackable
    {
        /// <summary>Führt einen Angriff aus und gibt den verursachten Schaden zurück.</summary>
        int Attack();
    }
}