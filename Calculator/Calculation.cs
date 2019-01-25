using System;

namespace Calculator
{
    class Calculation
    {
        private double number1, number2;
        private char symbol;

        public double Calculate(double number1, double number2, char symbol)
        {
            this.number1 = number1;
            this.number2 = number2;
            this.symbol = symbol;
            switch (symbol)
            {
                case '+':
                    {
                        return number1 + number2;
                    }
                case '-':
                    {
                        return number1 - number2;
                    }
                case '*':
                    {
                        return number1 * number2;
                    }
                case '/':
                    {
                        if (Math.Abs(number2) < 0.000000000001)
                            throw new AppException("Division by Zero");
                        return number1 / number2;
                    }
                default:
                    {
                        throw new AppException("Invalid expression");
                    }
            }
        }
    }
}
