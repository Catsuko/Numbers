using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersTests.Numbers;

namespace NumbersTests
{
    [TestClass]
    public class SubtractionTests
    {
        [TestMethod]
        public void ZeroMinusZero()
        {
            var zero = new Zero();
            Assert.AreEqual(zero, zero.Minus(zero));
        }

        [TestMethod]
        public void OneMinusZero()
        {
            var zero = new Zero();
            var one = zero.Next();
            Assert.AreEqual(one, one.Minus(zero));
        }

        [TestMethod]
        public void OneMinusOne()
        {
            var zero = new Zero();
            var one = zero.Next();
            Assert.AreEqual(zero, one.Minus(one));
        }

        [TestMethod]
        public void TwoMinusOne()
        {
            var one = new Zero().Next();
            var two = one.Next();
            Assert.AreEqual(one, two.Minus(one));
        }

        [TestMethod]
        public void FourMinusTwo()
        {
            var two = new Zero().Next().Next();
            var four = two.Next().Next();
            Assert.AreEqual(two, four.Minus(two));
        }

        [TestMethod]
        public void NegativeOneMinusOne()
        {
            var one = new Zero().Next();
            var negOne = one.Invert();
            Assert.AreEqual(negOne.Previous(), negOne - one);
        }

        [TestMethod]
        public void NegativeThreeMinusTwo()
        {
            var two = new Zero().Next().Next();
            var negThree = two.Next().Invert();
            Assert.AreEqual(negThree.Previous().Previous(), negThree - two);
        }

        [TestMethod]
        public void NegativeOneMinusNegativeOne()
        {
            var zero = new Zero();
            var negOne = zero.Previous();
            Assert.AreEqual(zero, negOne - negOne);
        }

        [TestMethod]
        public void NegativeTwoMinusNegativeThree()
        {
            var zero = new Zero();
            var negTwo = zero.Previous().Previous();
            var negThree = negTwo.Previous();
            Assert.AreEqual(zero.Next(), negTwo - negThree);
        }

        [TestMethod]
        public void OneMinusNegativeTwo()
        {
            var one = new Zero().Next();
            var negTwo = one.Next().Invert();
            Assert.AreEqual(one.Next().Next(), one - negTwo);
        }
    }
}
