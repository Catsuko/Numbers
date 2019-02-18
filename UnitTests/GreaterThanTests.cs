using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersTests.Numbers;

namespace NumbersTests
{
    [TestClass]
    public class GreaterThanTests
    {
        [TestMethod]
        public void OneGreaterThanZero ()
        {
            var zero = new Zero();
            var one = zero.Next();
            Assert.IsTrue(one.GreaterThan(zero));
        }

        [TestMethod]
        public void ZeroNotGreaterThanOne ()
        {
            var zero = new Zero();
            var one = zero.Next();
            Assert.IsFalse(zero.GreaterThan(one));
        }

        [TestMethod]
        public void TwoGreaterThanOne ()
        {
            var one = new Zero().Next();
            var two = one.Next();
            Assert.IsTrue(two.GreaterThan(one));
        }

        [TestMethod]
        public void OneNotGreaterThanTwo ()
        {
            var one = new Zero().Next();
            var two = one.Next();
            Assert.IsFalse(one.GreaterThan(two));
        }

        [TestMethod]
        public void ZeroGreaterThanNegativeOne ()
        {
            var zero = new Zero();
            var negOne = zero.Previous();
            Assert.IsTrue(zero.GreaterThan(negOne));
        }

        [TestMethod]
        public void NegativeOneGreaterThanNegativeTwo ()
        {
            var negOne = new Zero().Previous();
            var negTwo = negOne.Previous();
            Assert.IsTrue(negOne.GreaterThan(negTwo));
        }

        [TestMethod]
        public void NegativeTwoNotGreaterThanNegativeOne ()
        {
            var negOne = new Zero().Previous();
            var negTwo = negOne.Previous();
            Assert.IsFalse(negTwo.GreaterThan(negOne));
        }

        [TestMethod]
        public void ZeroNotGreaterThanZero ()
        {
            var zero = new Zero();
            Assert.IsFalse(zero.GreaterThan(zero));
        }

        [TestMethod]
        public void OneNotGreaterThanOne ()
        {
            var one = new Zero().Next();
            Assert.IsFalse(one.GreaterThan(one));
        }

        [TestMethod]
        public void NegativeOneNotGreaterThanNegativeOne ()
        {
            var negOne = new Zero().Previous();
            Assert.IsFalse(negOne.GreaterThan(negOne));
        }
    }
}
