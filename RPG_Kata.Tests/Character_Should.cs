using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RPG_Kata.Tests
{
    [TestClass]
    public class Character_Should
    {
        [TestMethod]
        public void Have_One_Thousand_Health_Upon_Creation()
        {
            var character = new Character();
            Assert.AreEqual(1000, character.Health);
        }

        [TestMethod]
        public void Have_Level_One_Upon_Creation()
        {
            var character = new Character();
            Assert.AreEqual(1, character.Level);
        }

        [TestMethod]
        public void Have_Alive_Property_Equals_True_Upon_Creation()
        {
            var character = new Character();
            Assert.IsTrue(character.Alive);
        }

        [TestMethod]
        public void Have_Health_Reduced_When_Damage_Is_Dealt()
        {
            var attackingCharacter = new Character();
            var damagedCharacter = new Character();
            var initialHealth = damagedCharacter.Health;

            attackingCharacter.Attack(damagedCharacter);

            Assert.IsTrue(damagedCharacter.Health < initialHealth);
        }

        [TestMethod]
        public void Have_Alive_Equals_False_When_Damage_Exceeds_Current_Health()
        {
            var attackingCharacter = new Character();
            var damagedCharacter = new Character { Health = 10 };

            attackingCharacter.Attack(damagedCharacter);

            Assert.IsFalse(damagedCharacter.Alive);
        }

        [TestMethod]
        public void Have_Health_Equals_Zero_When_Damage_Exceeds_Current_Health()
        {
            var attackingCharacter = new Character();
            var damagedCharacter = new Character { Health = 10 };

            attackingCharacter.Attack(damagedCharacter);

            Assert.AreEqual(0, damagedCharacter.Health);
        }

        [TestMethod]
        public void Have_Health_Increased_When_Healed_Not_Exceed_One_Thousand()
        {
            var characterToHeal = new Character { Health = 990 };

            characterToHeal.Heal();

            Assert.AreEqual(1000, characterToHeal.Health);
        }

        [TestMethod]
        public void Not_Be_Able_To_Damage_Itself()
        {
            var character = new Character();
            var initialHealth = character.Health;

            character.Attack(character);

            Assert.AreEqual(initialHealth, character.Health);
        }
    }
}
