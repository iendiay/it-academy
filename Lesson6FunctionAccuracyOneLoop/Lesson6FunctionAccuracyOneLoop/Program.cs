using System;

/* 
 * v. 3
 * y1 = 3 * x - (x + 1 / x) * Math.Log(1 - x * x) + 2 * Math.Log((1 - x) / (1 + x))
 * y2 = Sum (Math.Pow(x, 2 * k + 1) / k * (k + 1) * (2 * k + 1)) from k = 1 to k = infinity
 * 
 */

namespace Lesson6FunctionsAccuracyOneLoop
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            double y1 = 0, y2 = 0, x = 0;
            double rowMember = 0;
            int k = 1;
            int i = 0, j = 0;

            bool flag = false;

            //accuracy
            double e = 0.01;

            double xStart = -0.6;

            int rowQuantity = 20;
            //int columnQuantity = 0;

            double[,] array = new double[20, 8];


            x = xStart;

            while (e >= 0.0001)
            {
                for (i = 0; i < rowQuantity; i++)
                {
                    if (!flag)
                    {
                        array[i, j] = x;
                        y1 = 3 * x - (x + 1 / x) * Math.Log(1 - x * x) + 2 * Math.Log((1 - x) / (1 + x));
                        array[i, j + 1] = y1;
                        //Console.WriteLine("x = {0:0.00} y = {1:0.000000}", array[i, 0], array[i, 1]);

                    }

                    do
                    {
                        rowMember = Math.Pow(x, 2 * k + 1) / (k * (k + 1) * (2 * k + 1));
                        //Console.WriteLine(rowMember);
                        //Console.WriteLine(x);
                        if (Math.Abs(rowMember) < e)
                        {
                            break;
                        }

                        y2 = y2 + rowMember;
                        Console.WriteLine(e);
                        array[i, j + 2] = y2;
                        array[i, j + 3] = k;
                        k++;
                    }
                    while (true);

                    //Console.WriteLine("x = {0:0.00} y = {1:0.0000} k = {2}", x, y2, k);
                    y2 = 0;
                    k = 1;
                    x = Math.Round(x + 0.05, 2);
                }

                e = e / 10;
                x = xStart;
                j = j + 2;
                flag = true;
            }
        

            //output table
            Console.Clear();

            for (i = 0; i < 8; i++) 
            {
                if (i != 3 && i != 5 && i != 7)
                {
                    Console.SetCursorPosition(i * Console.WindowWidth / 8, 0);
                    Console.Write("|");
                }
            }

            Console.SetCursorPosition(Console.WindowWidth - 1, 0);
            Console.Write("|");

            Console.SetCursorPosition(1, 0);
            Console.Write("x");

            Console.SetCursorPosition(11, 0);
            Console.Write("f1(x)");

            Console.SetCursorPosition(21, 0);
            Console.Write(Convert.ToChar(949) + " = 0.01");

            Console.SetCursorPosition(41, 0);
            Console.Write(Convert.ToChar(949) + " = 0.001");

            Console.SetCursorPosition(61, 0);
            Console.Write(Convert.ToChar(949) + " = 0.0001");

            Console.SetCursorPosition(21, 2);
            Console.Write("f2(x)");

            Console.SetCursorPosition(31, 2);
            Console.Write("N");

            Console.SetCursorPosition(41, 2);
            Console.Write("f2(x)");

            Console.SetCursorPosition(51, 2);
            Console.Write("N");

            Console.SetCursorPosition(61, 2);
            Console.Write("f2(x)");

            Console.SetCursorPosition(71, 2);
            Console.Write("N");

            Console.SetCursorPosition(0, 1);
            Console.Write("|");

            Console.SetCursorPosition(Console.WindowWidth/8, 1);
            Console.Write("|");

            Console.SetCursorPosition(2 * Console.WindowWidth/8, 1);

            for (i = 2*Console.WindowWidth/8; i < Console.WindowWidth; i++)
            {
                //Console.SetCursorPosition(2 * Console.WindowWidth / 8, 1);
                Console.Write("-");
            }

            for (i = 0; i < 8; i++)
            {
                Console.SetCursorPosition(i * Console.WindowWidth / 8, 2);
                Console.Write("|");

            }

            Console.SetCursorPosition(Console.WindowWidth - 1, 2);
            Console.Write("|");

            for (i = 0; i < Console.WindowWidth; i++)
            {
                Console.SetCursorPosition(i, 3);
                Console.Write("-");
            }

            for (i = 0; i < rowQuantity - 1; i++)
            {
                for (j = 0; j < Console.WindowWidth; j++)
                {
                    if ((j % (Console.WindowWidth/8) == 0) && j < Console.WindowWidth)
                    {

                        Console.SetCursorPosition(j, i + 4);
                        Console.Write("|");
                        Console.WriteLine(Math.Round(array[i, j / (Console.WindowWidth / 8)], 4));
                        //Console.WriteLine(array[i, 1]);
                    }

                    Console.SetCursorPosition(Console.WindowWidth-1, i + 4);
                    Console.Write("|");
                }
            }


            /*
            for(i = 0; i < 20; i++)
            {
                for(j = 0; j < 8; j++)
                {
                    Console.WriteLine(Math.Round(array[i, j], 4));
                }
            }
            */

            Console.ReadKey(true);

        }
    }
}
