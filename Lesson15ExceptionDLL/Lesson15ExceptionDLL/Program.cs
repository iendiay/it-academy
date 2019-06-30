using System;

namespace Lesson15ExceptionDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            do
            {
                Console.WriteLine("Input command:");
                switch (Console.ReadLine())
                {
                    case "+":
                        calc.Addition();
                        break;
                    case "-":
                        calc.Subtraction();
                        break;
                    case "*":
                        calc.Multiplication();
                        break;
                    case "/":
                        try
                        {
                            calc.Division();
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }                           }
                        catch(ValueException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case "exit":
                        return;
                }
            }
            while (true);




        }
    }
}
