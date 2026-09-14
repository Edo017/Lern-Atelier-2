using System;

namespace VerfluchterDungeon
{
    /// <summary>Ein Gegner, der einmalig nach dem Tod mit wenig HP wiederauferstehen kann.</summary>
    public class Skeleton : Enemy
    {
        /// <summary>Gibt an, ob das Skelett bereits reassembliert wurde.</summary>
        private bool _hasReassembled = false;

        /// <summary>Erstellt ein neues Skelett.</summary>
        /// <param name="name">Anzeigename des Skeletts.</param>
        /// <param name="hp">Start-Lebenspunkte.</param>
        /// <param name="attackPower">Grundangriffswert.</param>
        public Skeleton(string name, int hp, int attackPower)
            : base(name, hp, attackPower)
        {
        }

        /// <summary>
        /// Lässt das Skelett einmalig mit 5 HP wiederauferstehen, sofern es besiegt wurde
        /// und dies noch nicht geschehen ist.
        /// </summary>
        /// <returns><c>true</c>, wenn die Reassemblierung erfolgreich war, sonst <c>false</c>.</returns>
        public bool Reassemble()
        {
            if (_hasReassembled || Hp > 0)
            {
                return false;
            }
            _hasReassembled = true;
            Hp = 5;
            return true;
        }
    }
}