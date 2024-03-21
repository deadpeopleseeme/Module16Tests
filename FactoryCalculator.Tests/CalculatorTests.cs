namespace FactoryCalculator.Tests
{
    public class CalculatorTests
    {
        [Test]
        public void Addition_MustReturnCorrectValue()
        {
            Calculator calculator = new();
            Assert.That(calculator.Addition(20, 10), Is.EqualTo(30));
        }

        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            Calculator calculator = new();
            Assert.That(calculator.Subtraction(20, 10), Is.EqualTo(10));
        }

        [Test]
        public void Miltiplication_MustReturnCorrectValue()
        {
            Calculator calculator = new();
            Assert.That(calculator.Miltiplication(20, 10), Is.EqualTo(200));
        }

        [Test]
        public void Division_MustReturnCorrectValue()
        {
            Calculator calculator = new();
            Assert.That(calculator.Division(20, 10), Is.EqualTo(2));
        }

        [Test]
        public void Division_MustThrowException()
        {
            Calculator calculator = new();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(20, 0));
        }
    }
}