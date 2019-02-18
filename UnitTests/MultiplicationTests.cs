using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numbers;

namespace NumbersTests
{
    [TestClass]
    public class MultiplicationTests
    {
        [TestMethod]
        public void ZeroTimesOne()
        {
            var zero = new Zero();
            var one = zero.Next();
            Assert.AreEqual(zero, zero.Times(one));
        }

        [TestMethod]
        public void ZeroTimesNegativeFive()
        {
            var zero = new Zero();
            var negFive = zero.Previous().Previous().Previous().Previous().Previous();
            Assert.AreEqual(zero, zero.Times(negFive));
        }

        [TestMethod]
        public void OneTimesOne()
        {
            var one = new Zero().Next();
            Assert.AreEqual(one, one * one);
        }

        [TestMethod]
        public void OneTimesTwo()
        {
            var one = new Zero().Next();
            var two = one.Next();
            Assert.AreEqual(two, one * two);
        }

        [TestMethod]
        public void SixTimesTwo()
        {
            var two = new Zero().Next().Next();
            var six = two + two + two;
            Assert.AreEqual(six + six, six * two);
        }

        [TestMethod]
        public void ThreeTimesZero()
        {
            var zero = new Zero();
            var three = zero.Next().Next().Next();
            Assert.AreEqual(zero, three * zero);
        }

        [TestMethod]
        public void NegativeOneTimesNegativeOne()
        {
            var negOne = new NegativeNumber(new Zero());
            Assert.AreEqual(negOne.Invert(), negOne * negOne);
        }

        [TestMethod]
        public void NegativeOneTimesTwo()
        {
            var zero = new Zero();
            var negOne = zero.Previous();
            var two = negOne.Previous().Invert();
            Assert.AreEqual(two.Invert(), negOne * two);
        }

        [TestMethod]
        public void OneTimesNegativeOne()
        {
            var one = new Zero();
            var negOne = one.Invert();
            Assert.AreEqual(negOne, one * negOne);
        }

        [TestMethod]
        public void NegativeOneTimesZero()
        {
            var zero = new Zero();
            var negOne = zero.Previous();
            Assert.AreEqual(zero, negOne * zero);
        }
    }
}
