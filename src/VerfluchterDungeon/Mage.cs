using System;
using System.Diagnostics.CodeAnalysis;
using VerfluchterDungeon;

/// <summary>
/// Repräsentiert einen Magier-Charakter mit Lebenspunkten, Angriffskraft und ausgerüsteter Waffe.
/// </summary>
public class Mage
{
    /// <summary>
    /// Der Name des Magiers.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Die aktuellen Lebenspunkte (HP) des Magiers.
    /// </summary>
    public int Hp { get; set; }

    /// <summary>
    /// Die Angriffskraft des Magiers, beeinflusst die Stärke seiner Zauber.
    /// </summary>
    public int AttackPower { get; set; }

    /// <summary>
    /// Die aktuell ausgerüstete Waffe des Magiers.
    /// </summary>
    public Weapon EquippedWeapon { get; set; }

    /// <summary>
    /// Erstellt einen neuen Magier mit den angegebenen Startwerten.
    /// </summary>
    /// <param name="name">Der Name des Magiers.</param>
    /// <param name="hp">Die Start-Lebenspunkte des Magiers.</param>
    /// <param name="attackPower">Die Angriffskraft des Magiers.</param>
    /// <param name="equippedWeapon">Die Waffe, die der Magier zu Beginn ausgerüstet hat.</param>
    [SetsRequiredMembers]
    public Mage(string name, int hp, int attackPower, Weapon equippedWeapon)
    {
        Name = name;
        Hp = hp;
        AttackPower = attackPower;
        EquippedWeapon = equippedWeapon;
    }

    /// <summary>
    /// Zufallsgenerator zur Berechnung des Zauberschadens.
    /// </summary>
    private Random RandomGenerator { get; } = new Random();

    /// <summary>
    /// Wirkt einen Zauber, dessen Schaden zufällig zwischen der Angriffskraft
    /// und dem Dreifachen der Angriffskraft liegt.
    /// </summary>
    /// <returns>Der berechnete Schaden des Zaubers.</returns>
    public int CastSpell()
    {
        return RandomGenerator.Next(AttackPower, AttackPower * 3 + 1);
    }
}