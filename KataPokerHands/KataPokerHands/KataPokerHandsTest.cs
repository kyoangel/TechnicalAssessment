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

        [TestMethod]
        public void HighCard_White_Win_A()
        {
            var comparor = new PokerHandsComparor();
            var actual = comparor.compare("2H 3D 5S 9C KD", "2C 3H 4S 8C AH");
            Assert.AreEqual("White wins. - with high card: Ace", actual);
        }

        [TestMethod]
        public void HighCard_White_Win_K()
        {
            var comparor = new PokerHandsComparor();
            var actual = comparor.compare("2H 3D 5S 9C QD", "2C 3H 4S 8C KH");
            Assert.AreEqual("White wins. - with high card: King", actual);
        }
    }
}