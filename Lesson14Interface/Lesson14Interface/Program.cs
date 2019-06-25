using System;

namespace Lesson14Interface
{
    public interface IBird
    {
        void Eat();
        void Sing();
        void Fly();
    }

    public class Nightingale : IBird
    {
        public void Eat()
        {
            Console.WriteLine("Nightingale is eating.");
        }

        public void Sing()
        {
            Console.WriteLine("Nightingale is singing.");
        }

        public void Fly()
        {
            Console.WriteLine("Nightingale is flying.");
        }
    }

    public class Pigeon : IBird
    {
        public void Eat()
        {
            Console.WriteLine("Pigeon is eating.");
        }

        public void Sing()
        {
            Console.WriteLine("Pigeon is singing.");
        }

        public void Fly()
        {
            Console.WriteLine("Pigeon is flying.");
        }
    }

    public class Penguin : IBird
    {
        public void Eat()
        {
            Console.WriteLine("Penguin is eating.");
        }

        public void Sing()
        {
            Console.WriteLine("Penguin is singing.");
        }

        public void Fly()
        {
            Console.WriteLine("Penguin is flying.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Nightingale n = new Nightingale();
            n.Eat();

            Pigeon pi = new Pigeon();
            pi.Sing();

            Penguin pen = new Penguin();
            pen.Fly();
            //Console.WriteLine("Hello World!");
        }
    }
}
