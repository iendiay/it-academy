using System;

namespace Lesson9LibraryConsole
{
    public class Book
    {
        private uint id;
        private string name;
        private string author;
        private string yearOfPublishing;
        DateTime dateOfRenting;
        private bool expired = false;
        private uint readerID;

        public Book()
        {

        }

        public uint ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        /*
        public uint GetID()
        {
            return id;
        }
        */
        public void InputBookData()
        {
            Console.WriteLine("Input the book name:");
            name = Console.ReadLine();

            Console.WriteLine("Input the book author:");
            author = Console.ReadLine();

            Console.WriteLine("Input the year of book publishing:");
            yearOfPublishing = Console.ReadLine();

            dateOfRenting = DateTime.Today;

            id = Library.BookCounter;

            Console.WriteLine("Input reader ID:");
            readerID = Convert.ToUInt32(Console.ReadLine());

        }


    }
}
