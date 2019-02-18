using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersTests.Numbers;

namespace NumbersTests
{
    [TestClass]
    public class DivisionTests
    {
        [TestMethod]
        public void ZeroDividedByOne ()
        {
            var zero = new Zero();
            var one = zero.Next();
            Assert.AreEqual(zero, zero.DividedBy(zero));
        }

        [TestMethod]
        public void OneDividedByOne ()
        {
            var one = new Zero().Next();
            Assert.AreEqual(one, one.DividedBy(one));
        }

        [TestMethod]
        public void TwoDividedByOne ()
        {
            var one = new Zero().Next();
            var two = one.Next();
            Assert.AreEqual(two, two.DividedBy(one));
        }

        [TestMethod]
        public void TenDividedByOne ()
        {
            var one = new Zero().Next();
            var ten = one.Next().Next().Next().Next().Next().Next().Next().Next();
            Assert.AreEqual(ten, ten.DividedBy(one));
        }

        [TestMethod]
        public void OneDividedByThree ()
        {
            var one = new Zero().Next();
            var three = one.Next().Next();
            Assert.AreEqual(new Zero(), one.DividedBy(three));
        }

        [TestMethod]
        public void DivideByZeroRaisesError ()
        {
            var zero = new Zero();
            var one = zero.Next();
            Assert.ThrowsException<System.Exception>(() => one.DividedBy(zero));
        }

        [TestMethod]
        public void NegativeOneDividedByOne ()
        {
            var one = new Zero().Next();
            var negOne = one.Invert();
            Assert.AreEqual(negOne, negOne.DividedBy(one));
        }

        [TestMethod]
        public void OneDividedByNegativeOne()
        {
            var one = new Zero().Next();
            var negOne = one.Invert();
            Assert.AreEqual(negOne, one.DividedBy(negOne));
        }

        [TestMethod]
        public void NegativeTenDividedByFive ()
        {
            var negTwo = new Zero().Previous().Previous();
            var five = negTwo.Plus(negTwo).Previous().Invert();
            var negTen = five.Times(negTwo);
            Assert.AreEqual(negTwo, negTen.DividedBy(five));
        }
    }
}
