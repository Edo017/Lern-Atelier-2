using System;
using VerfluchterDungeon;

public class DamageCalculator
    {
        private const int MinDamageRoll = 1;
        private Random RandomGenerator { get; } = new Random();

        public int CalculateDamage(int attackPower, int weaponDamage)
        {
            int baseDamage = RandomGenerator.Next(MinDamageRoll, attackPower + 1);
            return baseDamage + weaponDamage;
        }
    }
