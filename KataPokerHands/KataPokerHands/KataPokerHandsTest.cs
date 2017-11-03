using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataPokerHands
{
    [TestClass]
    public class KataPokerHandsTest
    {
        [TestMethod]
        public void empty()
        {
            var comparor = new PokerHandsComparor();
            var actual = comparor.compare("", "");
            Assert.AreEqual("Tie", actual);
        }
    }

    public class PokerHandsComparor
    {
        public string compare(string black, string white)
        {
            return "Tie";
        }
    }
}