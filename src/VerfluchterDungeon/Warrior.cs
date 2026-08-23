using System;
using System.Diagnostics.CodeAnalysis;
using VerfluchterDungeon;

namespace VerfluchterDungeon
{
    /// <summary>
    /// Repräsentiert einen Krieger-Charakter mit Lebenspunkten, Angriffskraft und ausgerüsteter Waffe.
    /// </summary>
    public class Warrior
    {
        /// <summary>
        /// Der Name des Kriegers.
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Die aktuellen Lebenspunkte (HP) des Kriegers.
        /// </summary>
        public int Hp { get; set; }

        /// <summary>
        /// Die Angriffskraft des Kriegers, beeinflusst den maximal möglichen Basisschaden.
        /// </summary>
        public int AttackPower { get; set; }

        /// <summary>
        /// Die aktuell ausgerüstete Waffe des Kriegers.
        /// </summary>
        public Weapon EquippedWeapon { get; set; }

        /// <summary>
        /// Erstellt einen neuen Krieger mit den angegebenen Startwerten.
        /// </summary>
        /// <param name="name">Der Name des Kriegers.</param>
        /// <param name="hp">Die Start-Lebenspunkte des Kriegers.</param>
        /// <param name="attackPower">Die Angriffskraft des Kriegers.</param>
        /// <param name="equippedWeapon">Die Waffe, die der Krieger zu Beginn ausgerüstet hat.</param>
        [SetsRequiredMembers]
        public Warrior(string name, int hp, int attackPower, Weapon equippedWeapon)
        {
            Name = name;
            Hp = hp;
            AttackPower = attackPower;
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
        /// Führt einen starken Angriff (Bash) aus, der den doppelten Waffenschaden verursacht.
        /// </summary>
        /// <returns>Der berechnete Gesamtschaden des Bash-Angriffs.</returns>
        public int Bash()
        {
            int baseDamage = RandomGenerator.Next(MinDamageRoll, AttackPower + 1);
            return baseDamage + (EquippedWeapon.Damage * 2);
        }

        /// <summary>
        /// Führt einen Standard-Angriff aus.
        /// </summary>
        /// <returns>Der berechnete Gesamtschaden.</returns>
        public int Attack()
        {
            int baseDamage = RandomGenerator.Next(MinDamageRoll, AttackPower + 1);
            return baseDamage + EquippedWeapon.Damage;
        }
    }
}