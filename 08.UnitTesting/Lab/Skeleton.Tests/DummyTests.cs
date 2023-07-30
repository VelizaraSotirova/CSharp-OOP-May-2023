using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void ConstructorShouldInitializeCorrectly()
        {
            Dummy dummy = new(100, 100);
            Assert.AreEqual(100, dummy.Health);
        }

        [Test]
        public void TakeAttackShouldDecreaseHealth()
        {
            Dummy dummy = new(100, 100);
            dummy.TakeAttack(50);
            Assert.AreEqual(50, dummy.Health);
        }

        [Test]
        public void TakeAttackShouldThrowExceptionIfDummyIsDead()
        {
            Dummy dummy = new(100, 100);
            dummy.TakeAttack(50);
            dummy.TakeAttack(50);
            Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(50), "Dummy is dead");
        }

        [Test]
        public void GiveExperienceShouldReturnCurrentExperienceIfDummyIsDead()
        {
            Dummy dummy = new(100, 100);
            dummy.TakeAttack(50);
            dummy.TakeAttack(50);
            Assert.AreEqual(100, dummy.GiveExperience());
        }

        [Test]
        public void GiveExperienceShouldThrowAnExceptionIfDummyIsNotDead()
        {
            Dummy dummy = new(100, 100);
            dummy.TakeAttack(50);
            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience(), "Target is not dead");
        }

        [Test]
        public void IsDeadShouldCheckIfHealthIsBelowOrEqualToZero()
        {
            Dummy dummy = new Dummy(50, 100);
            dummy.TakeAttack(50);
            Assert.IsTrue(dummy.IsDead());
        }
    }
}