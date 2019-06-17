using System;

namespace Lesson10oop
{
    class Shape2D
    {
        public int X { get; set; }
        public int Y { get; set; }

    }

    class Rectangle : Shape2D
    {
        public float D;

        /*
        public Rectangle(Shape2D shape)
        {
            X = shape.X;
            Y = shape.Y;
            D = Math.Sqrt(X*X+Y*Y);
        }
        */
        public virtual int Perimetr()
        {
            return 2 * (X + Y);
        }

        public virtual int Square()
        {
            return X * Y;
        }  

        public float getDiagonal()
        {
            return D;
        }
           
    }

    class Quadrate:Rectangle
    {
        public Quadrate(Shape2D shape)
        {
            X = shape.X;
        }

        public override int Perimetr()
        {
            return 4 * X;
        }

        public override int Square()
        {
            return X * X;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape2D s = new Shape2D();
            s.X = 10;
            s.Y = 10;

            Rectangle rect = new Rectangle();
            //rect.X = 10;
            //rect.Y = 20;
            //Console.WriteLine(rect.Square());

            Quadrate q = new Quadrate(s);
            Console.WriteLine("Square perimeter: " + q.Perimetr());

            rect = q;
            Console.WriteLine("Square area: " + rect.Square());

        }
    }
}
