using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersTests.Numbers;

namespace NumbersTests
{
    [TestClass]
    public class MultipleOperationsTests
    {
        [TestMethod]
        public void TwoPlusThreeMinusOne()
        {
            var one = new Zero().Next();
            var two = one.Next();
            var three = two.Next();
            Assert.AreEqual(three.Next(), two.Plus(three).Minus(one));
        }

        [TestMethod]
        public void ZeroMinusThreePlusSix()
        {
            var zero = new Zero();
            var three = zero.Next().Next().Next();
            var six = three.Next().Next().Next();
            Assert.AreEqual(three, zero.Minus(three).Plus(six));
        }

        [TestMethod]
        public void NegativeTwoPlusNegativeThreePlusTen()
        {
            var zero = new Zero();
            var two = zero.Next().Next();
            var three = two.Next();
            var five = three.Plus(two);
            var ten = five.Plus(five);
            var negTwo = two.Invert();
            var negThree = three.Invert();
            Assert.AreEqual(five, negTwo.Plus(negThree).Plus(ten));
        }
    }
}
