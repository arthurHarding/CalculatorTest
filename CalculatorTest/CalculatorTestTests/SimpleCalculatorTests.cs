using CalculatorTest;

namespace CalculatorTestTests
{
    public class Tests
    {
        private SimpleCalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new SimpleCalculator();
        }

        [Test]
        public void Add_AddPositiveNumber_GetCorrectAnswer()
        {
            var startValue = 42;
            var amountValue = 50;
            var expectedAnswer = 92;
            var answer = _calculator.Add(startValue, amountValue);
            Assert.IsTrue(answer == expectedAnswer);
        }

        [Test]
        public void Add_AddBigNumber_GetCorrectAnswer()
        {
            var startValue = 42;
            var amountValue = 5000000;
            var expectedAnswer = 5000042;
            var answer = _calculator.Add(startValue, amountValue);
            Assert.IsTrue(answer == expectedAnswer);
        }

        [Test]
        public void Add_AddNegativeNumber_GetCorrectAnswer()
        {
            var startValue = 42;
            var amountValue = -50;
            var expectedAnswer = -8;
            var answer = _calculator.Add(startValue, amountValue);
            Assert.IsTrue(answer == expectedAnswer);
        }

        [Test]
        public void Add_AddZero_GetCorrectAnswer()
        {
            var startValue = 42;
            var amountValue = 0;
            var expectedAnswer = 42;
            var answer = _calculator.Add(startValue, amountValue);
            Assert.IsTrue(answer == expectedAnswer);
        }

        [Test]
        public void Subtract_SubtractPositiveNumber_GetCorrectAnswer()
        {
            var startValue = 42;
            var amountValue = 50;
            var expectedAnswer = -8;
            var answer = _calculator.Subtract(startValue, amountValue);
            Assert.IsTrue(answer == expectedAnswer);
        }

        [Test]
        public void Subtract_SubtractBigNumber_GetCorrectAnswer()
        {
            var startValue = 42;
            var amountValue = 5000000;
            var expectedAnswer = -4999958;
            var answer = _calculator.Subtract(startValue, amountValue);
            Assert.IsTrue(answer == expectedAnswer);
        }

        [Test]
        public void Subtract_SubtractNegativeNumber_GetCorrectAnswer()
        {
            var startValue = 42;
            var amountValue = -50;
            var expectedAnswer = 92;
            var answer = _calculator.Subtract(startValue, amountValue);
            Assert.IsTrue(answer == expectedAnswer);
        }

        [Test]
        public void Subtract_SubtractZero_GetCorrectAnswer()
        {
            var startValue = 42;
            var amountValue = 0;
            var expectedAnswer = 42;
            var answer = _calculator.Subtract(startValue, amountValue);
            Assert.IsTrue(answer == expectedAnswer);
        }
    }
}