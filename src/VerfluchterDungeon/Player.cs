using System;
using VerfluchterDungeon;

/// <summary>
/// Repräsentiert den Spielercharakter mit Lebenspunkten, Angriffskraft und ausgerüsteter Waffe.
/// </summary>
public class Player
{
    /// <summary>
    /// Der Name des Spielers.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Die aktuellen Lebenspunkte (HP) des Spielers.
    /// </summary>
    public int Hp { get; set; }

    /// <summary>
    /// Die Angriffskraft des Spielers, beeinflusst den maximal möglichen Basisschaden.
    /// </summary>
    public int AttackPower { get; set; }

    /// <summary>
    /// Die aktuell ausgerüstete Waffe des Spielers.
    /// </summary>
    public Weapon EquippedWeapon { get; set; }

    /// <summary>
    /// Erstellt einen neuen Spieler mit den angegebenen Startwerten.
    /// </summary>
    /// <param name="name">Der Name des Spielers.</param>
    /// <param name="hp">Die Start-Lebenspunkte des Spielers.</param>
    /// <param name="AttackPower">Die Angriffskraft des Spielers.</param>
    /// <param name="equippedWeapon">Die Waffe, die der Spieler zu Beginn ausgerüstet hat.</param>
    public Player(string name, int hp, int AttackPower, Weapon equippedWeapon)
    {
        Name = name;
        Hp = hp;
        this.AttackPower = AttackPower;
        EquippedWeapon = equippedWeapon;
    }

    /// <summary>
    /// Der minimal mögliche Wert für den zufälligen Basisschaden.
    /// </summary>
    private const int MinDamageRoll = 1;

    /// <summary>
    /// Zufallsgenerator zur Berechnung des Basisschadens bei einem Angriff.
    /// </summary>
    private Random RandomGenerator { get; } = new Random();

    /// <summary>
    /// Führt einen Angriff aus und berechnet den daraus resultierenden Gesamtschaden
    /// aus zufälligem Basisschaden und dem Schaden der ausgerüsteten Waffe.
    /// </summary>
    /// <returns>Der berechnete Gesamtschaden des Angriffs.</returns>
    private readonly DamageCalculator _damageCalculator = new DamageCalculator();

    public int Attack()
    {   
        return _damageCalculator.CalculateDamage(AttackPower, EquippedWeapon.Damage);
    }
    
}   