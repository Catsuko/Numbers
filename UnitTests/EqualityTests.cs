using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numbers;

namespace NumbersTests
{
    [TestClass]
    public class EqualityTests
    {
        [TestMethod]
        public void OneEqualsOne()
        {
            var zero = new Zero();
            Assert.AreEqual(zero.Next(), zero.Next());
        }

        [TestMethod]
        public void ZeroEqualsZero()
        {
            Assert.AreEqual(new Zero(), new Zero());
        }

        [TestMethod]
        public void NegativeOneEqualsNegativeOne()
        {
            var zero = new Zero();
            Assert.AreEqual(zero.Previous(), zero.Previous());
        }

        [TestMethod]
        public void NegativeOneDoesNotEqualOne ()
        {
            var one = new Zero().Next();
            var negOne = one.Invert();
            Assert.AreNotEqual(negOne, one);
        }

        [TestMethod]
        public void TwoDoesNotEqualOne ()
        {
            var one = new Zero().Next();
            var two = one.Next();
            Assert.AreNotEqual(two, one);
        }
    }
}
