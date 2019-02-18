using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numbers;

namespace NumbersTests
{
    [TestClass]
    public class OperatorTests
    {
        [TestMethod]
        public void OnePlusOne ()
        {
            var one = new Zero().Next();
            Assert.AreEqual(one.Next(), one + one);
        }

        [TestMethod]
        public void OneMinusOne ()
        {
            var zero = new Zero();
            var one = zero.Next();
            Assert.AreEqual(zero, one - one);
        }

        [TestMethod]
        public void OneGreaterThanZero ()
        {
            var zero = new Zero();
            var one = zero.Next();
            Assert.IsTrue(one > zero);
        }

        [TestMethod]
        public void ZeroLessThanOne ()
        {
            var zero = new Zero();
            var one = zero.Next();
            Assert.IsTrue(zero < one);
        }
    }
}
