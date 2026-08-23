using System;
using System.Diagnostics.CodeAnalysis;
using VerfluchterDungeon;

/// <summary>
/// Repräsentiert einen Heiler-Charakter mit Lebenspunkten, Heilkraft und ausgerüsteter Waffe.
/// </summary>
public class Healer
{
    /// <summary>
    /// Der Name des Heilers.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Die aktuellen Lebenspunkte (HP) des Heilers.
    /// </summary>
    public int Hp { get; set; }

    /// <summary>
    /// Die Heilkraft des Heilers.
    /// </summary>
    public int HealingPower { get; set; }

    /// <summary>
    /// Die aktuell ausgerüstete Waffe des Heilers.
    /// </summary>
    public Weapon EquippedWeapon { get; set; }

    /// <summary>
    /// Erstellt einen neuen Heiler mit den angegebenen Startwerten.
    /// </summary>
    /// <param name="name">Der Name des Heilers.</param>
    /// <param name="hp">Die Start-Lebenspunkte des Heilers.</param>
    /// <param name="healingPower">Die Heilkraft des Heilers.</param>
    /// <param name="equippedWeapon">Die Waffe, die der Heiler zu Beginn ausgerüstet hat.</param>
    [SetsRequiredMembers]
    public Healer(string name, int hp, int healingPower, Weapon equippedWeapon)
    {
        Name = name;
        Hp = hp;
        HealingPower = healingPower;
        EquippedWeapon = equippedWeapon;
    }

    /// <summary>
    /// Heilt den Heiler um einen festen Betrag, indem die Lebenspunkte entsprechend erhöht werden.
    /// </summary>
    /// <returns>Der Betrag, um den die Lebenspunkte erhöht wurden.</returns>
    public int Heal()
    {
        const int HealAmount = 6;
        Hp += HealAmount;
        return HealAmount;
    }
}