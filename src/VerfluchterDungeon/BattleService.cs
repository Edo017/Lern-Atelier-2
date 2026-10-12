using System;

namespace VerfluchterDungeon
{
    /// <summary>Fuehrt Kaempfe zwischen zwei IAttackable-Teilnehmern durch.</summary>
    public class BattleService
    {
        /// <summary>
        /// Laesst zwei Teilnehmer gegeneinander kaempfen, bis eine Seite 0 HP erreicht.
        /// </summary>
        /// <param name="a">Erster Teilnehmer (z.B. der Player).</param>
        /// <param name="b">Zweiter Teilnehmer (z.B. ein Enemy).</param>
        public void Fight(IAttackable a, IAttackable b)
        {
            while (a.Hp > 0 && b.Hp > 0)
            {
                b.Hp -= a.Attack();
                if (b.Hp <= 0)
                {
                    break;
                }
                a.Hp -= b.Attack();
            }
            Console.WriteLine(a.Hp > 0 ? "Seite A gewinnt." : "Seite B gewinnt.");
        }
    }
}
