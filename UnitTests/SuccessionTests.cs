using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numbers;

namespace NumbersTests
{
    [TestClass]
    public class SuccessionTests
    {
        [TestMethod]
        public void NegativeOneNext()
        {
            var zero = new Zero();
            var negOne = zero.Next().Invert();
            Assert.AreEqual(zero, negOne.Next());
        }

        [TestMethod]
        public void NegativeTwoNext()
        {
            var negOne = new Zero().Next().Invert();
            var negTwo = negOne.Previous();
            Assert.AreEqual(negOne, negTwo.Next());
        }
    }
}
