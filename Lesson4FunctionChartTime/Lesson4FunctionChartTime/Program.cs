using System;

/* 
 * Output function values with x parameter (for a to b with h increment)
 * y = |7.2 - 10 * x| / sqrt(x / 9 + x^3 / 4) * atan(4 * x / 5 / (1.11 + x^2))
 * 
 * Tasks.
 * 1. Output values of the function with a, b, h parameters (a is a start value, b is a finish value, h is an increment).
 * 2. Output the chart.
 * 3. Output the function perfomance time.
 * 4. Non-string value test.
 * 5. Overflow test.
 * 
 */

namespace Lesson3Function
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double x, y, a = 0, b = 0, h = 0;
            int counter = 0; //for the first time in the loop
            int consoleWidth, consoleHeight;
            int xPosition = 0, yPosition = 0;
            double yMin = 0, yMax = 0;

            //strings for the non-string test
            string aString, bString, hString;

            //date and span 
            DateTime startTime = new DateTime();
            DateTime finishTime = new DateTime();
            TimeSpan perfomanceTime = new TimeSpan();

            //console window size
            consoleWidth = Console.WindowWidth;
            consoleHeight = Console.WindowHeight;
            //Console.WriteLine($"console width: {consoleWidth} console height = {consoleHeight}");

            //while parameters are invalid
            do
            {
                Console.WriteLine("Please input only positive numeric values (a > 0, b > 0, h > 0)");

                Console.Write("Input a: ");
                aString = Console.ReadLine();

                if (!Double.TryParse(aString, out a))
                {
                    continue;
                }

                //overflow test
                if (a > Double.MaxValue)
                {
                    Console.WriteLine("Please input a value less than 1.79769313486232E+308");
                }

                Console.Write("Input b: ");
                bString = Console.ReadLine();

                if (!Double.TryParse(bString, out b))
                {
                    continue;
                }

                //overflow test
                if (b > Double.MaxValue)
                {
                    Console.WriteLine("Please input a value less than 1.79769313486232E+308");
                }

                Console.Write("Input h: ");
                hString = Console.ReadLine();

                if (!Double.TryParse(hString, out h))
                {
                    continue;
                }

                //overflow test
                if (h > Double.MaxValue)
                {
                    Console.WriteLine("Please input a value less than 1.79769313486232E+308");
                }

            }
            while (!(a > 0 && b > 0 && h > 0));


            startTime = DateTime.Now;

            //y(min) and y(max) searching 
            for (x = a; x <= b; x += h)
            {
                y = Math.Abs(7.2 - 10 * x) / Math.Sqrt(x / 9 + Math.Pow(x, 3) / 4) * Math.Atan(4 * x / 5 / (1.11 + Math.Pow(x, 2)));
                Console.WriteLine($"x = {x} y = {y}");

                if (counter == 0) //if it is the first time in the loop
                {
                    yMin = y;
                    yMax = y;
                    counter++;
                }

                if (yMin > y)
                {
                    yMin = y;
                }

                if (yMax < y)
                {
                    yMax = y;
                }

                //overflow test
                if (y > Double.MaxValue)
                {
                    Console.WriteLine($"Function value is overflowed with x = {x}");
                    goto endProgram; //if y is overflowed end the program
                }

            }

            //perfomance time calculating
            finishTime = DateTime.Now;
            perfomanceTime = finishTime - startTime;
            Console.WriteLine($"Function perfomance time: {perfomanceTime.Milliseconds} milliseconds");

            //output y(min) and y(max)
            Console.WriteLine($"y(min) = {yMin} y(max) = {yMax}");
            Console.ReadKey();

            Console.Clear();

            //Console.WriteLine($"a = {a} b = {b}");

            //output the chart with scale
            for (x = a; x <= b; x += h)
            {
                y = Math.Abs(7.2 - 10 * x) / Math.Sqrt(x / 9 + Math.Pow(x, 3) / 4) * Math.Atan(4 * x / 5 / (1.11 + Math.Pow(x, 2)));

                xPosition = (int)(x * (consoleWidth - 1) / b); //x-scale formula 
                yPosition = Math.Abs((int)(y * (consoleHeight - 1) / yMax) - consoleHeight); //y-scale formula with y-inversion

                if (yPosition == consoleHeight)
                {
                    yPosition = consoleHeight - 1;
                }

                Console.SetCursorPosition(xPosition, yPosition);
                //Console.WriteLine($"x = {x} y = {y}");
                //Console.WriteLine($"xpos = {xPosition} ypos = {yPosition}");
                //Console.WriteLine($"width = {consoleWidth} ymax = {yMax}");
                Console.Write(".");

            }

        endProgram:
            Console.ReadKey();

        }
    }
}
