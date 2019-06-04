using System;

/*
 * Move arrow by WASD keys.
 * 
 */

namespace Lesson4WASD
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            int arrowUp = 9651,
                arrowRight = 9655,
                arrowDown = 9661,
                arrowLeft = 9665;

            int symbol = arrowUp;
            ConsoleKeyInfo k;
            int positionX, positionY;

            positionX = Console.WindowWidth / 2;
            positionY = Console.WindowHeight / 2;

            Console.CursorVisible = false;

            do
            {
                Console.SetCursorPosition(positionX, positionY);
                Console.Write(Convert.ToChar(symbol));
                k = Console.ReadKey(true);

                switch (k.Key)
                {
                    case ConsoleKey.W:
                        if(positionY > 0) 
                        positionY--;
                        symbol = arrowUp;
                        break;
                    case ConsoleKey.A:
                        if(positionX > 0)
                        positionX--;
                        symbol = arrowLeft;
                        break;
                    case ConsoleKey.S:
                        if(positionY < Console.WindowHeight - 1)
                        positionY++;
                        symbol = arrowDown;
                        break;
                    case ConsoleKey.D:
                        if(positionY < Console.WindowWidth - 1)
                        positionX++;
                        Console.WriteLine(positionY);
                        symbol = arrowRight;
                        break;
                    default:
                        break;
                }

                Console.Clear();
            }
            while (k.Key != ConsoleKey.Escape);

        }
    }
}
