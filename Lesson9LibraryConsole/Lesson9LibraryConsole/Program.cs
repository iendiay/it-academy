using System;

namespace Lesson9LibraryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Console.WriteLine("Commands:");
            Console.WriteLine("addb - add a book");
            Console.WriteLine("deleteb - delete a book" );
            Console.WriteLine("change - change book information");
            Console.WriteLine("showb - show books");
            Console.WriteLine("quit - exit the program");

            do
            {
                Console.WriteLine("Input command:");
                switch (Console.ReadLine())
                {
                    case "addb":
                        library.AddBook();
                        break;
                    case "deleteb":
                        library.DeleteBook();
                        break;
                    case "changeb":
                        library.ChangeBookInformation();
                        break;
                    case "showb":
                        library.ShowBooks();
                        break;
                    case "quit":
                        return;
                }
            }
            while (true);

            //library.AddBook();
            //library.AddBook();
            //library.ShowBooks();
            //library.ChangeBookInformation();
            //library.DeleteBook();

        }
    }
}
