using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersTests.Numbers;
using System.Text;

namespace NumbersTests
{
    [TestClass]
    public class SignTests
    {
        [TestMethod]
        public void SignOfZero ()
        {
            var zero = new Zero();
            Assert.AreEqual(zero, zero.Sign());
        }

        [TestMethod]
        public void SignOfOne ()
        {
            var one = new Zero().Next();
            Assert.AreEqual(one, one.Sign());
        }

        [TestMethod]
        public void SignOfNegOne ()
        {
            var negOne = new Zero().Previous();
            Assert.AreEqual(negOne, negOne.Sign());
        }

        [TestMethod]
        public void SignOfFive ()
        {
            var one = new Zero().Next();
            var five = one.Next().Next().Next().Next();
            Assert.AreEqual(one, five.Sign());
        }

        [TestMethod]
        public void SignOfNegThree ()
        {
            var negOne = new Zero().Previous();
            var negThree = negOne.Previous().Previous();
            Assert.AreEqual(negOne, negThree.Sign());
        }
    }
}
