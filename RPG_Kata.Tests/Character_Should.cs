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
    }
}
