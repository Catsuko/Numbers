using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersTests.Numbers;

namespace NumbersTests
{
    [TestClass]
    public class AbsoluteTests
    {
        [TestMethod]
        public void AbsoluteOfZero()
        {
            var zero = new Zero();
            Assert.AreEqual(zero, zero.Absolute());
        }

        [TestMethod]
        public void AbsoluteOfOne()
        {
            var one = new Zero().Next();
            Assert.AreEqual(one, one.Absolute());
        }

        [TestMethod]
        public void AbsoluteOfNegOne ()
        {
            var one = new Zero().Next();
            var negOne = one.Invert();
            Assert.AreEqual(one, negOne.Absolute());
        }

        [TestMethod]
        public void AbsoluteOfSix ()
        {
            var six = new Zero().Next().Next().Next().Next().Next().Next();
            Assert.AreEqual(six, six.Absolute());
        }

        [TestMethod]
        public void AbsoluteOfNegTwo ()
        {
            var two = new Zero().Next().Next();
            var negTwo = two.Invert();
            Assert.AreEqual(two, negTwo.Absolute());
        }
    }
}
