using System;

namespace Lesson9LibraryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.AddBook();
            library.ShowBooks();
            //Console.WriteLine("Hello World!");
            
        }
    }
}
