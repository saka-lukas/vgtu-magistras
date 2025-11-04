using System;
using Utilities;
using Xunit;

namespace Utilities.Tests
{
    public class MathFunctionsMoreTests
    {
        // ---- Subtract ----
        [Theory]
        [InlineData(10, 3, 7)]
        [InlineData(3, 10, -7)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, -2, -3)]
        public void Subtract_ShouldReturnCorrectDifference(double a, double b, double expected)
        {
            // Arrange
            var math = new MathFunctions();

            // Act
            var result = math.Subtract(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        // ---- Multiply ----
        [Theory]
        [InlineData(4, 5, 20)]
        [InlineData(-3, 6, -18)]
        [InlineData(-2, -8, 16)]
        [InlineData(0, 100, 0)]
        public void Multiply_ShouldReturnCorrectProduct(double a, double b, double expected)
        {
            // Arrange
            var math = new MathFunctions();

            // Act
            var result = math.Multiply(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        // ---- Divide (success cases) ----
        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(-9, 3, -3)]
        [InlineData(7, -2, -3.5)]
        [InlineData(1, 3, 0.3333333333)]
        public void Divide_ShouldReturnCorrectQuotient(double a, double b, double expected)
        {
            // Arrange
            var math = new MathFunctions();

            // Act
            var result = math.Divide(a, b);

            // Assert
            // Use precision for floating-point comparisons (number of decimal places)
            Assert.Equal(expected, result, 6);
        }

        // Divide by zero is already covered in TwoShotExample, but here's a variant using InlineData
        [Theory]
        [InlineData(0, 0)]
        [InlineData(10, 0)]
        [InlineData(-5, 0)]
        public void Divide_ShouldThrowException_WhenDividingByZero_Variants(double a, double b)
        {
            // Arrange
            var math = new MathFunctions();

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => math.Divide(a, b));
        }

        // ---- Power ----
        [Theory]
        [InlineData(2, 3, 8)]
        [InlineData(5, 0, 1)]
        [InlineData(2, -2, 0.25)]
        [InlineData(-2, 3, -8)]
        public void Power_ShouldReturnCorrectResult(double @base, double exponent, double expected)
        {
            // Arrange
            var math = new MathFunctions();

            // Act
            var result = math.Power(@base, exponent);

            // Assert
            Assert.Equal(expected, result, 6);
        }

        // ---- SquareRoot (success) ----
        [Theory]
        [InlineData(0, 0)]
        [InlineData(4, 2)]
        [InlineData(9, 3)]
        [InlineData(2, 1.41421356237)]
        public void SquareRoot_ShouldReturnCorrectResult(double value, double expected)
        {
            // Arrange
            var math = new MathFunctions();

            // Act
            var result = math.SquareRoot(value);

            // Assert
            Assert.Equal(expected, result, 6);
        }

        // ---- SquareRoot (error) ----
        [Theory]
        [InlineData(-1)]
        [InlineData(-0.0001)]
        public void SquareRoot_ShouldThrowArgumentException_WhenNegative(double value)
        {
            // Arrange
            var math = new MathFunctions();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => math.SquareRoot(value));
        }

        // ---- Absolute ----
        [Theory]
        [InlineData(-5, 5)]
        [InlineData(0, 0)]
        [InlineData(3.5, 3.5)]
        [InlineData(-123.456, 123.456)]
        public void Absolute_ShouldReturnNonNegative(double value, double expected)
        {
            // Arrange
            var math = new MathFunctions();

            // Act
            var result = math.Absolute(value);

            // Assert
            Assert.Equal(expected, result, 6);
        }

        // ---- Factorial (success) ----
        [Theory]
        [InlineData(0, 1L)]
        [InlineData(1, 1L)]
        [InlineData(5, 120L)]
        [InlineData(10, 3628800L)]
        [InlineData(20, 2432902008176640000L)]
        public void Factorial_ShouldReturnCorrectResult(int n, long expected)
        {
            // Arrange
            var math = new MathFunctions();

            // Act
            var result = math.Factorial(n);

            // Assert
            Assert.Equal(expected, result);
        }

        // ---- Factorial (error) ----
        [Theory]
        [InlineData(-1)]
        [InlineData(-10)]
        public void Factorial_ShouldThrowArgumentException_WhenNegative(int n)
        {
            // Arrange
            var math = new MathFunctions();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => math.Factorial(n));
        }
    }
}
