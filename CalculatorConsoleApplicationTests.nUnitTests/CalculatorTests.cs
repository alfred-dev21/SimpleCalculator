namespace CalculatorConsoleApplicationTests.nUnitTests
{
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestCase("-2 + 5")]
        public void Addition_Test1(string intruction)
        {
            calculator.SetInstruction(intruction);

            string expected = "3";
            string actual = calculator.CalculatorHandler();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("-2 - 5")]
        public void Subtraction_Test1(string intruction)
        {
            calculator.SetInstruction(intruction);

            string expected = "-7";
            string actual = calculator.CalculatorHandler();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}