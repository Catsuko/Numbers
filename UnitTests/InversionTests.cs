using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numbers;

namespace NumbersTests
{
    [TestClass]
    public class InversionTests
    {
        [TestMethod]
        public void InvertZero ()
        {
            var zero = new Zero();
            Assert.AreEqual(zero, zero.Invert());
        }

        [TestMethod]
        public void InvertOne ()
        {
            var zero = new Zero();
            var one = zero.Next();
            Assert.AreEqual(zero.Previous(), one.Invert());
        }

        [TestMethod]
        public void InvertNegativeOne ()
        {
            var zero = new Zero();
            var negOne = zero.Previous();
            Assert.AreEqual(zero.Next(), negOne.Invert());
        }
    }
}
