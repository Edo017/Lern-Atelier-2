using System;

namespace VerfluchterDungeon
{
    /// <summary>Ein einfacher, schwacher Gegner.</summary>
    public class Goblin : Enemy
    {
        /// <summary>Erstellt einen neuen Goblin.</summary>
        /// <param name="name">Anzeigename des Goblins.</param>
        /// <param name="hp">Start-Lebenspunkte.</param>
        /// <param name="attackPower">Grundangriffswert.</param>
        public Goblin(string name, int hp, int attackPower)
            : base(name, hp, attackPower)
        {
        }
    }
}