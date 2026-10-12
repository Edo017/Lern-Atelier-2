using NUnit.Framework;
using VerfluchterDungeon;

namespace VerfluchterDungeon.Tests
{
    public class DamageCalculatorTests
    {
        [Test]
        public void CalculateDamage_NeverNegative()
        {
            DamageCalculator calc = new DamageCalculator();

            int damage = calc.CalculateDamage(5, 2);

            Assert.That(damage, Is.GreaterThanOrEqualTo(0));
        }

        [Test]
        public void CalculateDamage_AtLeastWeaponDamage()
        {
            DamageCalculator calc = new DamageCalculator();
            int weaponDamage = 3;

            int damage = calc.CalculateDamage(5, weaponDamage);

            Assert.That(damage, Is.GreaterThanOrEqualTo(weaponDamage));
        }
    }
}
