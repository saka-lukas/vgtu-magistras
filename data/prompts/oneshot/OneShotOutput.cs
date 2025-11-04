using System;
using Utilities;
using Xunit;

namespace Utilities.Tests
{
    public class MoreMathFunctionsTests
    {
        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            // Arrange
            var math = new MathFunctions();

            // Act
            var result = math.Subtract(10, 3);

            // Assert
            Assert.Equal(7, result);
        }

        [Fact]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            // Arrange
            var math = new MathFunctions();

            // Act
            var result = math.Multiply(4, 6);

            // Assert
            Assert.Equal(24, result);
        }

        [Fact]
        public void Divide_ShouldReturnCorrectQuotient_ForExactDivision()
        {
            // Arrange
            var math = new MathFunctions();

            // Act
            var result = math.Divide(20, 5);

            // Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void Divide_ShouldReturnCorrectQuotient_ForNonIntegerResult()
        {
            // Arrange
            var math = new MathFunctions();

            // Act
            var result = math.Divide(7, 2);

            // Assert
            Assert.Equal(3.5, result);
        }

        [Fact]
        public void Divide_ShouldThrow_WhenDividingByZero()
        {
            // Arrange
            var math = new MathFunctions();

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => math.Divide(1, 0));
        }

        [Fact]
        public void Power_ShouldReturnCorrectResult_ForPositiveExponent()
        {
            // Arrange
            var math = new MathFunctions();

            // Act
            var result = math.Power(2, 3);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Power_ShouldReturnOne_WhenExponentIsZero()
        {
            // Arrange
            var math = new MathFunctions();

            // Act
            var result = math.Power(5, 0);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void SquareRoot_ShouldReturnCorrectResult_ForPerfectSquare()
        {
            // Arrange
            var math = new MathFunctions();

            // Act
            var result = math.SquareRoot(81);

            // Assert
            Assert.Equal(9, result);
        }

        [Fact]
        public void SquareRoot_ShouldThrow_ForNegativeInput()
        {
            // Arrange
            var math = new MathFunctions();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => math.SquareRoot(-1));
        }

        [Fact]
        public void Absolute_ShouldReturnSameValue_ForPositiveNumber()
        {
            // Arrange
            var math = new MathFunctions();

            // Act
            var result = math.Absolute(12.34);

            // Assert
            Assert.Equal(12.34, result);
        }

        [Fact]
        public void Absolute_ShouldReturnPositive_ForNegativeNumber()
        {
            // Arrange
            var math = new MathFunctions();

            // Act
            var result = math.Absolute(-12.34);

            // Assert
            Assert.Equal(12.34, result);
        }

        [Fact]
        public void Absolute_ShouldReturnZero_ForZero()
        {
            // Arrange
            var math = new MathFunctions();

            // Act
            var result = math.Absolute(0);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Factorial_ShouldReturnOne_ForZero()
        {
            // Arrange
            var math = new MathFunctions();

            // Act
            var result = math.Factorial(0);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Factorial_ShouldReturnCorrectValue_ForSmallN()
        {
            // Arrange
            var math = new MathFunctions();

            // Act
            var result = math.Factorial(5);

            // Assert
            Assert.Equal(120, result);
        }

        [Fact]
        public void Factorial_ShouldHandleLargerN_WithoutOverflowWithinLong()
        {
            // Arrange
            var math = new MathFunctions();

            // Act
            var result = math.Factorial(20);

            // Assert
            // 20! = 2,432,902,008,176,640,000
            Assert.Equal(2432902008176640000L, result);
        }

        [Fact]
        public void Factorial_ShouldThrow_ForNegativeInput()
        {
            // Arrange
            var math = new MathFunctions();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => math.Factorial(-3));
        }

        [Fact]
        public void Add_ShouldBeCommutative()
        {
            // Arrange
            var math = new MathFunctions();

            // Act
            var ab = math.Add(2.5, 7.5);
            var ba = math.Add(7.5, 2.5);

            // Assert
            Assert.Equal(ab, ba);
        }

        [Fact]
        public void Multiply_ShouldBeCommutative()
        {
            // Arrange
            var math = new MathFunctions();

            // Act
            var ab = math.Multiply(3, 9);
            var ba = math.Multiply(9, 3);

            // Assert
            Assert.Equal(ab, ba);
        }
    }
}
