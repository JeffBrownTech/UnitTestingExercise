using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(-2, 3, 5, 6)]
        [InlineData(2, 0, 5, 7)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(10, -5, -8, -3)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator calc = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = calc.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 5)]//Add test data <-------
        [InlineData(0, 0, 0)]
        [InlineData(10, -5, 15)]
        [InlineData(0, -5, 5)]
        [InlineData(-10, -5, -5)]
        [InlineData(-10, 5, -15)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator calc = new Calculator();

            //Act
            var actual = calc.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 10, 100)]//Add test data <-------
        [InlineData(5, -5, -25)]
        [InlineData(-5, -5, 25)]
        [InlineData(-5, 5, -25)]
        [InlineData(-10, 0, 0)]
        [InlineData(10, 0, 0)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator calc = new Calculator();

            //Act
            var actual = calc.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(25, 5, 5)]//Add test data <-------
        [InlineData(10, 3, 3)]
        [InlineData(-10, 5, -2)]
        [InlineData(10, -5, -2)]
        [InlineData(-10, -5, 2)]
        [InlineData(0, 5, 0)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator calc = new Calculator();

            //Act
            var actual = calc.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
