using System;

namespace Utilities
{
    public class MathFunctions
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            return a / b;
        }
        public double Power(double baseValue, double exponent) => Math.Pow(baseValue, exponent);
        public double SquareRoot(double value)
        {
            if (value < 0)
                throw new ArgumentException();
            return Math.Sqrt(value);
        }
        public double Absolute(double value) => Math.Abs(value);
        public long Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException();
            long result = 1;
            for (int i = 2; i <= n; i++)
                result *= i;
            return result;
        }
    }
}
