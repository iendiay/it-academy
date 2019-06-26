using System;

namespace Lesson14Roulette
{
    class Program
    {
        class Roulette
        {
            public delegate void MethodContainer(string message);
            public event MethodContainer GetNumber;

            public void Spin()
            {
                Random rand = new Random();
                int number = rand.Next(0, 36);

                if (GetNumber != null)
                    GetNumber($"Number: {number}");
            }
        }


        static void Main(string[] args)
        {
            Roulette roulette = new Roulette();
            roulette.GetNumber += ShowMessage;

            ConsoleKeyInfo k;

            do
            {
                Console.WriteLine("Please spin the roulette by spacebar.");

                k = Console.ReadKey(true);

                if (k.Key == ConsoleKey.Spacebar)
                {
                    roulette.Spin();
                }   
            }
            while (k.Key != ConsoleKey.Escape);

            Console.ReadKey();

        }

        private static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        
    }
}
