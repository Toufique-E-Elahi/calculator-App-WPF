using System;

namespace WPFCalculator
{
    internal class Calculator
    {
        public Calculator()
        {
        }

        internal int add(int num1, int num2)
        {
            return num1 + num2;
        }
        internal int sub(int num1, int num2)
        {
            return num1 - num2;
        }
        internal int mul(int num1, int num2)
        {
            return num1 * num2;
        }
        internal int div(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}