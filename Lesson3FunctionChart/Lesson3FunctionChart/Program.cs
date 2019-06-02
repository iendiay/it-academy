using System;

namespace Lesson3Function
{
    class MainClass
    {
        public static object WindowWidth { get; private set; }

        public static void Main(string[] args)
        {
            double x, y, a, b, h;
            int i = 0;
            int consoleWidth, consoleHeight;
            int xPosition = 0, yPosition = 0;
            double yMin = 0, yMax = 0;

            //Console window size
            consoleWidth = Console.WindowWidth;
            consoleHeight = Console.WindowHeight;
            //Console.WriteLine($"console width: {consoleWidth} console height = {consoleHeight}");

            do
            {
                Console.WriteLine("Please input only positive values (a > 0, b > 0, h > 0)");
                Console.Write("Input a: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input b: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input h: ");
                h = Convert.ToDouble(Console.ReadLine());
            }
            while (!(a > 0 && b > 0 && h > 0));

            //Finding y(min) and y(max) 
            for (x = a; x <= b;)
            {
                y = Math.Abs(7.2 - 10 * x) / Math.Sqrt(x / 9 + Math.Pow(x, 3) / 4) * Math.Atan(4 * x / 5 / (1.11 + Math.Pow(x, 2)));
                Console.WriteLine($"x = {x} y = {y}");

                if (i == 0)
                {
                    yMin = y;
                    yMax = y;
                }

                if(yMin > y)
                {
                    yMin = y;
                }

                if(yMax < y)
                {
                    yMax = y;
                }

                x = x + h;
                i++;
            }
            Console.WriteLine($"y(min) = {yMin} y(max) = {yMax}");
            Console.ReadKey();
            Console.Clear();

            //Console.WriteLine($"a = {a} b = {b}");

            //Out the chart
            for (x = a; x <= b;)
            {
                y = Math.Abs(7.2 - 10 * x) / Math.Sqrt(x / 9 + Math.Pow(x, 3) / 4) * Math.Atan(4 * x / 5 / (1.11 + Math.Pow(x, 2)));
                xPosition = (int)(x * (consoleWidth - 1) / b);
                yPosition = Math.Abs((int)(y * (consoleHeight - 1) / yMax) - consoleHeight);
                if (yPosition == consoleHeight)
                {
                    yPosition = consoleHeight - 1;
                }
                Console.SetCursorPosition(xPosition, yPosition);
                //Console.WriteLine($"x = {x} y = {y}");
                //Console.WriteLine($"xpos = {xPosition} ypos = {yPosition}");
                //Console.WriteLine($"width = {consoleWidth} ymax = {yMax}");
                Console.Write(".");
                x = x + h;

            }
            Console.ReadKey();

        }
    }
}
