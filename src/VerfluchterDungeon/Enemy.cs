using System;
using VerfluchterDungeon;

/// <summary>
/// Repräsentiert einen Gegner mit Lebenspunkten und Angriffskraft.
/// </summary>
public class Enemy
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int AttackPower { get; set; }

        private readonly DamageCalculator _damageCalculator = new DamageCalculator();

        public Enemy(string name, int hp, int attackPower)
        {
            Name = name;
            Hp = hp;
            AttackPower = attackPower;
        }

        public virtual int Attack()
        {
            return _damageCalculator.CalculateDamage(AttackPower, 0);
        }
    }
