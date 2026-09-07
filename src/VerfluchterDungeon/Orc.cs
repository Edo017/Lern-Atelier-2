using System;

namespace VerfluchterDungeon
{
    public class Orc : Enemy
    {
        private const int OrcBonusDamage = 2;

        public Orc(string name, int hp, int attackPower)
            : base(name, hp, attackPower)
        {
        }

        public override int Attack()
        {
            return base.Attack() + OrcBonusDamage;
        }
    }
}