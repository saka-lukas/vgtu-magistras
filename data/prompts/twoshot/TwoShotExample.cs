using System;
using Utilities;
using Xunit;

namespace Utilities.Tests
{
    public class MathFunctionsTests
    {
        [Theory]
        [InlineData(3, 5, 8)]
        [InlineData(-2, 7, 5)]
        [InlineData(0, 0, 0)]
        public void Add_ShouldReturnCorrectSum(double a, double b, double expected)
        {
            // Arrange
            var math = new MathFunctions();

            // Act
            var result = math.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Divide_ShouldThrowException_WhenDividingByZero()
        {
            // Arrange
            var math = new MathFunctions();

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => math.Divide(10, 0));
        }
    }
}
