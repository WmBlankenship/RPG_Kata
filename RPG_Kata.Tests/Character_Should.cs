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
    }
}
