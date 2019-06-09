using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;

namespace Lesson6Collections
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            ArrayList arrNumbers = new ArrayList();

            arrNumbers.Add(1);
            arrNumbers.Add("Hello");
            arrNumbers.Add(7);
            arrNumbers.Add(10);
            arrNumbers.Add(25);

            arrNumbers.RemoveAt(2);
            arrNumbers.Remove(25);


            arrNumbers.Insert(1, 111);

            arrNumbers.Remove("Hello");
            arrNumbers.Sort();

            for(int i = 0; i < arrNumbers.Count; i++)
            {
                var value = arrNumbers[i];
                Console.WriteLine(value);
            }
            */


            /////list
            List<int> arrNumbers = new List<int>();

            arrNumbers.Add(1);
            arrNumbers.Add(23);
            arrNumbers.Add(7);
            arrNumbers.Add(10);
            arrNumbers.Add(25);

            arrNumbers.RemoveAt(2);
            arrNumbers.Remove(25);


            arrNumbers.Insert(1, 111);
            //arrNumbers.Remove("Hello");
            arrNumbers.Sort();

            for (int i = 0; i < arrNumbers.Count; i++)
            {
                var value = arrNumbers[i];
                Console.WriteLine(value);
            }

            foreach (var j in arrNumbers)
            {
                Console.WriteLine(j);
            }

            //////sorted list
            SortedList myList = new SortedList();
            myList.Add(20, "Computer");
            myList.Add(30, "TV");
            myList.Add(5, "House");

            foreach (var key in myList.Keys)
            {
                Console.WriteLine("Key = " + key + ", value = " + myList[key]);
            }

            myList.Remove(30);

            object Value = myList[20];
            bool isFound = myList.ContainsKey(25);

            Console.WriteLine(isFound);

            myList.Add(25, "Camera");
            isFound = myList.ContainsKey(25);
            Console.WriteLine(isFound);

            Console.WriteLine(myList.Capacity);

            ///////stack
            Stack myStack = new Stack();
            myStack.Push("Computer");
            myStack.Push("TV");
            myStack.Push("House");

            foreach (object item in myStack)
                Console.WriteLine(item);

            isFound = myStack.Contains("TV");

            object Value1 = myStack.Peek();
            object Value2 = myStack.Peek();

            object value1 = myStack.Pop();
            object value2 = myStack.Pop();
            object value3 = myStack.Pop();

            Console.WriteLine(isFound);

            foreach (object item in myStack)
                Console.WriteLine(item);



            ////////queue
            Queue myQueue = new Queue();

            myQueue.Enqueue("Computer");
            myQueue.Enqueue("TV");
            myQueue.Enqueue("House");


            foreach (object item in myQueue)
                Console.WriteLine(item);

            isFound = myQueue.Contains("TV");

            Value1 = myQueue.Peek();

            value1 = myQueue.Dequeue();

            foreach (object item in myQueue)
                Console.WriteLine(item);
        }


        //hashtable
        Hashtable myHash = new Hashtable();
        /*
        myHash.Add(20, "Computer");
            myHash.Add(20, "Computer");
            myHash.Add(20, "Computer");


            foreach()
            Console.w

            myHash[33] = "aaa";
        */
        }
    }
}
