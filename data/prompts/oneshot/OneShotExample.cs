using System;
using Utilities;
using Xunit;

namespace Utilities.Tests
{
    public class MathFunctionsTests
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            var math = new MathFunctions();

            // Act
            var result = math.Add(3, 5);

            // Assert
            Assert.Equal(8, result);
        }
    }
}

