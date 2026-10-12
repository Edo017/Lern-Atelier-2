namespace VerfluchterDungeon
{
    /// <summary>Vertrag fuer alles, was geheilt werden bzw. heilen kann.</summary>
    public interface IHealable
    {
        /// <summary>Heilt und gibt die Anzahl geheilter Lebenspunkte zurueck.</summary>
        int Heal();
    }
}
