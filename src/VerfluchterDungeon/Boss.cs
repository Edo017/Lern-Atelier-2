using System;

namespace VerfluchterDungeon
{
    /// <summary>Endgegner des Dungeons - greift bei niedrigen HP wuetend an.</summary>
    public class Boss : Enemy
    {
        private const int EnrageHpThresholdPercent = 30;
        private readonly int _maxHp;

        /// <summary>Erstellt einen neuen Boss.</summary>
        /// <param name="name">Anzeigename des Bosses.</param>
        /// <param name="hp">Start- und zugleich maximale Lebenspunkte.</param>
        /// <param name="attackPower">Grundangriffswert.</param>
        public Boss(string name, int hp, int attackPower)
            : base(name, hp, attackPower)
        {
            _maxHp = hp;
        }

        /// <summary>
        /// Wie Enemy.Attack(), aber verdoppelt bei niedrigen HP (Wut-Mechanik).
        /// </summary>
        /// <returns>Der verursachte Schaden in Punkten.</returns>
        public override int Attack()
        {
            int damage = base.Attack();
            if (IsEnraged())
            {
                damage *= 2;
            }
            return damage;
        }

        private bool IsEnraged()
        {
            return Hp * 100 / _maxHp < EnrageHpThresholdPercent;
        }
    }
}