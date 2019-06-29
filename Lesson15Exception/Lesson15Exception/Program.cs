using System;

namespace Lesson15Exception
{
    class MyType
    {
        public int DataMember;
    }

    class Tests
    {
        public void GenerateException()
        {
            MyType cls = null;
            cls.DataMember = 10;
        }

        public void RunAll()
        {
            //GenerateException();
            //GenerateDivideByZeroException();
        }

        public void GenerateDivideByZeroException()
        {
            int i = 10;
            int j = 0;

            i = i / j;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] number = {4, 8, 1, 2, 5, 6, 12, 11 };
            int[] denom = {2, 0 , 4, 4, 0, 8 };

            try
            {
                for (int i = 0; i < number.Length; i++)
                {
                    try
                    {
                        Console.WriteLine(number[i] + "/" + denom[i] + "  ravno " + number[i] / denom[i]);
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Delenie na nul!");

                    }
                    catch(IndexOutOfRangeException)
                    {
                        Console.WriteLine("Vyhod za predely massiva!");
                        throw;
                    }
                }
            
            }
            catch
            {

            }

            try
            {
                Console.WriteLine("Do generirivaniya");
                throw new DivideByZeroException();
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Perehvacheno");
            }

            Tests tests = new Tests();
            tests.RunAll();

            Console.WriteLine("Hello World!");
            //Console.ReadLine();
        }
    }
}
