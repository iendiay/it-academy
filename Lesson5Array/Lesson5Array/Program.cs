using System;
using System.Collections.Generic;

namespace Lesson5Array
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int n = 100;
            int sum = 0;
            int[] array = new int[n];
            int chet = 0, nechet = 0;

            int i, j;


            //input 6 values in the array
            for(i = 0; i < 6; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(i = 0; i < 6; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine("-------------");

            //input 100 values in the array 
            //output even and odd values
            //output the sum of elements 
            //output ariphmetic average of elements
            Random r = new Random();

            for (i = 0; i < n; i++)
            {
                array[i] = r.Next(0, 100);
                sum = sum + array[i];
                Console.Write($"{array[i]} ");

                if(array[i] % 2 == 0)
                {
                    if(array[i] != 0)
                    chet++;
                }
                else
                {
                    nechet++;
                }

            }

            Console.WriteLine();
            Console.WriteLine($"sum = {sum}");

            float ariph;
            ariph =(float)sum / (float)n;
            Console.WriteLine($"srednee arif = {Math.Round(ariph, 3)}");

            Console.WriteLine($"chet = {chet}");
            Console.WriteLine($"nechet = {nechet}");


            //read values from the file
            /*
            int[] A;
            string[] _lines = System.IO.File.ReadAllLines(@"file2.rtf");
            List<int> A_list = new List<int>();

            foreach (var _line in _lines)
            {
                A_list.Add(int.Parse(_line));
            }

            A = A_list.ToArray();
            */


            int[,] matrix = {       { 3 , 1, 2},
                                     { 5, 10, 0},
                                     { 20, 50, 30} };

          
            int m = 3; //5
            int max = 0;

            j = 0;

            for (i = 0; i < m; i++)
            {
                max = matrix[i, j];
                for (j = 0; j < m; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }

                }
                Console.WriteLine($"{max}");
            }

            int maxRow = 0;
            i = 0;
            for (j = 0; j < m ; j++)
            {
                maxRow = matrix[i, j];
                for (i = 0; i < m; i++)
                {
                    if (matrix[i, j] > maxRow)
                    {
                        maxRow = matrix[i, j];
                    }

                }
                Console.WriteLine($"{maxRow}");
            }


            int[] data = { 1, 5, 7, 4, 3 };
            var sum2 = 0;
            foreach (var element in data)
                sum2 += element;
            Console.WriteLine($"sum2 = {sum2}");

                

        }
    }
}

