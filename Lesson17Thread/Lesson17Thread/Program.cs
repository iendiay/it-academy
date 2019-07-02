using System;
using System.IO;
using System.Threading;

namespace Lesson17Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Start();
            }
        }

        private static void Func()
        {
            Console.WriteLine("Func{0}", Thread.CurrentThread.GetHashCode());
        }

        public static void Start()
        {
            Console.WriteLine("Main(){0}", Thread.CurrentThread.GetHashCode());
            ThreadStart del = new ThreadStart(Func);
            Thread th = new Thread(del);
            
            th.Start();
            
        }
    }
}
