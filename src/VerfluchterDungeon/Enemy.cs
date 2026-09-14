using System;
using VerfluchterDungeon;

/// <summary>
/// Repräsentiert einen Gegner mit Lebenspunkten und Angriffskraft.
/// </summary>
public class Enemy
{
    /// <summary>Der Name des Gegners.</summary>
    public string Name { get; set; }

    /// <summary>Die aktuellen Lebenspunkte des Gegners.</summary>
    public int Hp { get; set; }

    /// <summary>Die Angriffskraft des Gegners.</summary>
    public int AttackPower { get; set; }

    /// <summary>Dient zur Berechnung des Schadens bei Angriffen.</summary>
    private readonly DamageCalculator _damageCalculator = new DamageCalculator();

    /// <summary>Erstellt einen neuen Gegner mit den angegebenen Startwerten.</summary>
    /// <param name="name">Der Name des Gegners.</param>
    /// <param name="hp">Die Start-Lebenspunkte des Gegners.</param>
    /// <param name="attackPower">Die Angriffskraft des Gegners.</param>
    public Enemy(string name, int hp, int attackPower)
    {
        Name = name;
        Hp = hp;
        AttackPower = attackPower;
    }

    /// <summary>Führt einen Standardangriff aus.</summary>
    /// <returns>Der berechnete Schaden.</returns>
    public virtual int Attack()
    {
        return _damageCalculator.CalculateDamage(AttackPower, 0);
    }
}