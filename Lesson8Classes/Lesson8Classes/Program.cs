using System;

namespace Lesson8Classes
{

    class MyClass
    {
        public int X = 10;
        private int Y = 10;

        public int val1;

        int _val1;

        public int Val
        {
            get
            {
                return _val1 + 10000;
            }

            set
            {
                if (value == 10)
                {
                    _val1 = 0;
                }
                else
                {
                    _val1 = value;
                }

            }
        }

        public void PrintField()
        {
            Console.WriteLine("Field - {0}", _val1);
        }

        public MyClass()
        {
            val1 = 6;
        }

        public MyClass(int t) : this()
        {
            val1 = val1 + t;
        }

        public MyClass(int a, int b) : this()
        {
            val1 = val1 + a + b;
        }

        public int Sum()
        {
            return X + Y;
        }

        public int GetDeltaX(ref int d)
        {
            return d = X - d;
        }

        public int GetDeltaY(int d)
        {
            return d = Y - d;
        }

        public int Add(int[] data)
        {
            int sum = 0;

            for (int i = 0; i < data.Length; i++)
            {
                sum = sum + data[i];
            }

            return sum;
        }


    }

    class NewClass
    {
        private int[] mass;

        public NewClass()
        {
            mass = new int[10];

            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = i;
            }
        }

        public int this[int index]
        {
            get
            {
                if((index > 0) & (index < mass.Length)) //&?
                {
                    return mass[index];
                }
                else
                {
                    return 0;
                }
            }

        }
    }


    class MainClass
    {
        public static void Main(string[] args)
        {

            var obj = new MyClass(3, 3);
            obj.PrintField();


            MyClass myClassObject = new MyClass();

            int a = 9;

            Console.WriteLine(myClassObject.GetDeltaY(a));
            Console.WriteLine(a);
            Console.WriteLine(myClassObject.GetDeltaX(ref a));
            Console.WriteLine(a);

            int[] myData = new int[4];
            /*
            myData[0] = 11;
            myData[1] = 22;
            myData[2] = 33;
            myData[3] = 44;
            */
            int sum;
            sum = myClassObject.Add(myData);
            Console.WriteLine(sum);

            var obj3 = new MyClass(3);
            obj3.Val = 7;
            obj3.PrintField();
            obj3.Val = 10;
            obj3.PrintField();

            int x = obj3.Val;
            Console.WriteLine(x);

            NewClass array = new NewClass();
            Console.WriteLine("Element: " + array[2]);
        }
    }
}
