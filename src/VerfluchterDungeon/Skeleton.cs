using System;

namespace VerfluchterDungeon
{
    public class Skeleton : Enemy
    {
        private bool _hasReassembled = false;

        public Skeleton(string name, int hp, int attackPower)
            : base(name, hp, attackPower)
        {
        }

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