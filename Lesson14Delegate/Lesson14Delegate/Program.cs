using System;

namespace Lesson14Delegate
{
    class Program
    {
        delegate int Transformer(int x);

        /////////
        delegate void Delegate1();
        delegate void Delegate2();


        static void Main(string[] args)
        {
            Transformer t = Square;
            Transformer t1 = Cube;

            Console.WriteLine(t.GetHashCode());
            Console.WriteLine(t1.GetHashCode());

            t += Square;
            t += Cube;
            Console.WriteLine(t.GetHashCode());

            t += Square;
            Console.WriteLine(t.GetHashCode());

            int result = t(3);
            //Console.WriteLine(result);

            t -= Square;
            Console.WriteLine(t.GetHashCode());

            result = t(3);
            //Console.WriteLine(result);

            /////////////////////////
            Console.WriteLine("------------------");

            Delegate1 del1 = new Delegate1(Method);
            Delegate2 del2 = new Delegate2(Method);

            //int result = del2;
            //del2 = del1.Invoke;
            del2.Invoke();
            Delegate2 del3 = new Delegate2(del1);
            Delegate del = new Delegate1(Method);
            Console.WriteLine(del.GetType().BaseType.Name);
        }

        static int Square(int x)
        {
            Console.WriteLine(x*x);
            return x * x;
        }

        static int Cube(int x)
        {
            Console.WriteLine(x*x*x);
            return x * x * x;
        }

        /////////////
        static void Method()
        {
            Console.WriteLine("Method");
        }
    }
}
