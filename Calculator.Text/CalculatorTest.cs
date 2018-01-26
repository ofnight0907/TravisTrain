using System;
using NUnit.Framework;

namespace Calculator.Text
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void AddTest()
        {
            ICalculator cal = new Calculator();
            int result = cal.Add(5, 6);
            Assert.That(result, Is.EqualTo(11));
        }

        [Test]
        public void SubTest()
        {
            ICalculator cal = new Calculator();
            int result = cal.Sub(5, 6);
            Assert.That(result, Is.EqualTo(-2));
        }

        [Test]
        public void MulTest()
        {
            ICalculator cal = new Calculator();
            int result = cal.Mul(5, 6);
            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        public void DivTest()
        {
            ICalculator cal = new Calculator();
            int result = cal.Div(5, 6);
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
