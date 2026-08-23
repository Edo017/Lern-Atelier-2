using System;

namespace VerfluchterDungeon
{
    /// <summary>
    /// Repräsentiert eine Waffe mit einem Namen und einem Schadenswert.
    /// </summary>
    public class Weapon
    {
        /// <summary>
        /// Der Name der Waffe.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Der Schadenswert, den die Waffe bei einem Angriff hinzufügt.
        /// </summary>
        public int Damage { get; set; }

        /// <summary>
        /// Erstellt eine neue Waffe mit dem angegebenen Namen und Schadenswert.
        /// </summary>
        /// <param name="name">Der Name der Waffe.</param>
        /// <param name="damage">Der Schadenswert der Waffe.</param>
        public Weapon(string name, int damage)
        {
            Name = name;
            Damage = damage;
        }
    }
}