using System;

namespace Lesson15ExceptionDLL
{
    public class Calculator
    {
        private decimal number1;
        private decimal number2;
        private decimal result;

        public Calculator()
        {
            number1 = 0;
            number2 = 0;
            result = 0;
        }

        public void Input()
        {
            string input;
            bool tryParseBool;

            Console.WriteLine("Input number1:");
            input = Console.ReadLine();
            tryParseBool = Decimal.TryParse(input, out number1);

            if(!tryParseBool)
            {
                throw new ValueException("The number1 is not a number!");
            }

            Console.WriteLine("Input number2:");
            input = Console.ReadLine();
            tryParseBool = Decimal.TryParse(input, out number2);

            if (!tryParseBool)
            {
                throw new ValueException("The number2 is not a number!");
            }
        }

        public void Addition()
        {
            Input();
            result = number1 + number2;
            Output();
        }

        public void Subtraction()
        {
            Input();
            result = number1 - number2;
            Output();
        }

        public void Multiplication()
        {
            Input();
            result = number1 * number2;
            Output();
        }

        public void Division()
        {
            Input();
            result = number1 / number2;
            Output();
        }

        public void Output()
        {
            Console.WriteLine("Number1: " + number1 + " Number2: " + number2 + " Result: " + result);
        }
    }
}
