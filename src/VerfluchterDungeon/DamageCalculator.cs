using System;
using VerfluchterDungeon;

/// <summary>Berechnet den Schaden eines Angriffs.</summary>
public class DamageCalculator
{
    /// <summary>Der minimal mögliche Wert für den zufälligen Basisschaden.</summary>
    private const int MinDamageRoll = 1;

    /// <summary>Zufallsgenerator zur Berechnung des Basisschadens.</summary>
    private Random RandomGenerator { get; } = new Random();

    /// <summary>Berechnet den Gesamtschaden aus Angriffskraft und Waffenschaden.</summary>
    /// <param name="attackPower">Die Angriffskraft des Angreifers.</param>
    /// <param name="weaponDamage">Der Schadenswert der Waffe.</param>
    /// <returns>Der berechnete Gesamtschaden.</returns>
    public int CalculateDamage(int attackPower, int weaponDamage)
    {
        int baseDamage = RandomGenerator.Next(MinDamageRoll, attackPower + 1);
        return baseDamage + weaponDamage;
    }
}