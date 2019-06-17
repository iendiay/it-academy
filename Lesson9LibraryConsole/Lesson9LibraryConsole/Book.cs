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
        private uint readerID = 0;

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

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value;
            }
        }

        public string YearOfPublishing
        {
            get
            {
                return yearOfPublishing;
            }

            set
            {
                yearOfPublishing = value;
            }
        }


        public uint ReaderID
        {
            get
            {
                return readerID;
            }

            set
            {
                readerID = value;
            }
        }

        public Book()
        {

        }


        public void InputBookData()
        {
            Console.WriteLine("Input the book name:");
            name = Console.ReadLine();

            Console.WriteLine("Input the book author:");
            author = Console.ReadLine();

            Console.WriteLine("Input the year of book publishing:");
            yearOfPublishing = Console.ReadLine();

            //dateOfRenting = DateTime.Today;

            id = Library.BookCounter;

            /*
            Console.WriteLine("Input reader ID:");
            readerID = Convert.ToUInt32(Console.ReadLine());
            */
        }

        /*
        public void SearchBook(int id)
        {

        }
        */
    }
}
