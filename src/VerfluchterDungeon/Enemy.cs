using System;
using VerfluchterDungeon;

/// <summary>
/// Repräsentiert einen Gegner mit Lebenspunkten und Angriffskraft.
/// </summary>
public class Enemy
{
    /// <summary>
    /// Der Name des Gegners.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Die aktuellen Lebenspunkte (HP) des Gegners.
    /// </summary>
    public int Hp { get; set; }

    /// <summary>
    /// Die Angriffskraft des Gegners, beeinflusst den maximal möglichen Schaden.
    /// </summary>
    public int AttackPower { get; set; }

    /// <summary>
    /// Zufallsgenerator zur Berechnung des Schadens bei einem Angriff.
    /// </summary>
    private Random RandomGenerator { get; } = new Random();

    /// <summary>
    /// Führt einen Angriff aus und berechnet den dabei verursachten Schaden.
    /// </summary>
    /// <returns>Der berechnete Schaden des Angriffs.</returns>
    private readonly DamageCalculator _damageCalculator = new DamageCalculator();

    public int Attack()
    {   
        return _damageCalculator.CalculateDamage(AttackPower,0);
    }
}