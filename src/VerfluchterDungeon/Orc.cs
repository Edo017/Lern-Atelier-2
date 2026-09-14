using System;

namespace VerfluchterDungeon
{
    /// <summary>Ein Gegner mit erhöhtem Angriffsschaden.</summary>
    public class Orc : Enemy
    {
        /// <summary>Zusätzlicher Schaden, den der Orc bei jedem Angriff verursacht.</summary>
        private const int OrcBonusDamage = 2;

        /// <summary>Erstellt einen neuen Orc.</summary>
        /// <param name="name">Anzeigename des Orcs.</param>
        /// <param name="hp">Start-Lebenspunkte.</param>
        /// <param name="attackPower">Grundangriffswert.</param>
        public Orc(string name, int hp, int attackPower)
            : base(name, hp, attackPower)
        {
        }

        /// <summary>Wie Enemy.Attack(), aber mit zusätzlichem Bonusschaden.</summary>
        /// <returns>Der verursachte Schaden in Punkten.</returns>
        public override int Attack()
        {
            return base.Attack() + OrcBonusDamage;
        }
    }
}