using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void AxeLoosesDurabilityAfterAttack()
        {
            Axe axe = new(10, 10);
            Dummy dummy = new(10, 10);
            axe.Attack(dummy);
            Assert.That(axe.DurabilityPoints, Is.EqualTo(9), "Axe Durability doesn't change after attack");
        }

        [Test]
        public void AttackingWithABrokenWeapon()
        {
            Axe axe = new(10, 10);
            Dummy dummy = new(100, 100);

            for (int i = 0; i < 10; i++)
            {
                axe.Attack(dummy);
            }

            Assert.Throws<InvalidOperationException>(() =>  axe.Attack(dummy), "Axe is broken");
        }
    }
}