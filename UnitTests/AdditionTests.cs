using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersTests.Numbers;

namespace NumbersTests
{
    [TestClass]
    public class AdditionTests
    {
        [TestMethod]
        public void ZeroPlusOne()
        {
            var zero = new Zero();
            var one = zero.Next();
            Assert.AreEqual(one, zero.Plus(one));
        }

        [TestMethod]
        public void OnePlusZero()
        {
            var zero = new Zero();
            var one = zero.Next();
            Assert.AreEqual(one, one.Plus(zero));
        }

        [TestMethod]
        public void TwoPlusOne()
        {
            var one = new Zero().Next();
            var two = one.Next();
            Assert.AreEqual(two.Next(), two.Plus(one));
        }

        [TestMethod]
        public void OnePlusFour()
        {
            var one = new Zero().Next();
            var four = one.Next().Next().Next();
            Assert.AreEqual(four.Next(), one.Plus(four));
        }

        [TestMethod]
        public void OnePlusOne()
        {
            var one = new Zero().Next();
            Assert.AreEqual(one.Next(), one.Plus(one));
        }

        [TestMethod]
        public void FourPlusZero()
        {
            var zero = new Zero();
            var four = zero.Next().Next().Next().Next();
            Assert.AreEqual(four, four.Plus(zero));
        }

        [TestMethod]
        public void ZeroPlusZero()
        {
            var zero = new Zero();
            Assert.AreEqual(zero, zero.Plus(zero));
        }

        [TestMethod]
        public void NegativeOnePlusOne()
        {
            var zero = new Zero();
            var one = zero.Next();
            var negOne = one.Invert();
            Assert.AreEqual(zero, negOne.Plus(one));
        }

        [TestMethod]
        public void OnePlusNegativeOne()
        {
            var zero = new Zero();
            var one = zero.Next();
            var negOne = one.Invert();
            Assert.AreEqual(zero, one.Plus(negOne));
        }

        [TestMethod]
        public void NegativeTwoPlusFour()
        {
            var two = new Zero().Next().Next();
            var four = two.Next().Next();
            var negTwo = two.Invert();
            Assert.AreEqual(two, negTwo.Plus(four));
        }
    }
}
