namespace Calculator.Test.Unit
{
    using NUnit.Framework;

    [TestFixture]
    public class CalculatorUnitTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Init()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_Zero()
        {
            Assert.That(4, Is.EqualTo(_calculator.Add(4, 0)));
        }

        [Test]
        public void Add_ZeroReversed()
        {
            Assert.That(4, Is.EqualTo(_calculator.Add(0, 4)));
        }

        [Test]
        public void Add_PositiveNumbers()
        {
            Assert.That(9, Is.EqualTo(_calculator.Add(4, 5)));
        }

        [Test]
        public void Add_NegativeNumbers()
        {
            Assert.That(-14, Is.EqualTo(_calculator.Add(-5, -9)));
        }

        [Test]
        public void Add_ToInfinity()
        {
            Assert.That(double.PositiveInfinity, Is.EqualTo(_calculator.Add(double.MaxValue, double.MaxValue)));
        }

        [Test]
        public void Add_Zeros()
        {
            Assert.That(0, Is.EqualTo(_calculator.Add(0, 0)));
        }
    }
}