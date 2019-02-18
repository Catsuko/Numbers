using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersTests.Numbers;

namespace NumbersTests
{
    [TestClass]
    public class StringFormattingTests
    {
        [TestMethod]
        public void ZeroToString()
        {
            Assert.AreEqual(string.Empty, new Zero().ToString());
        }

        [TestMethod]
        public void OneToString()
        {
            var one = new Zero().Next();
            Assert.AreEqual("+", one.ToString());
        }

        [TestMethod]
        public void TwoToString()
        {
            var two = new Zero().Next().Next();
            Assert.AreEqual("++", two.ToString());
        }

        [TestMethod]
        public void NegativeOneToString()
        {
            var negOne = new Zero().Previous();
            Assert.AreEqual("-", negOne.ToString());
        }

        [TestMethod]
        public void NegativeFourToString ()
        {
            var negFour = new Zero().Previous().Previous().Previous().Previous();
            Assert.AreEqual("----", negFour.ToString());
        }
    }
}
