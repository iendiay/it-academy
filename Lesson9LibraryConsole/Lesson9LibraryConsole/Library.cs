using System;
using System.Collections.Generic;
using System.IO;


namespace Lesson9LibraryConsole
{
    public class Library
    {
        List<Book> books = new List<Book>();
        List<Reader> readers = new List<Reader>();
        private Book book;
        private Reader reader;

        private static uint bookCounter = 0;

        private string filePath = @"library.txt";

        public static uint BookCounter
        {
            get
            {
                return bookCounter;
            }

            set
            {
                bookCounter = value;
            }
        }

        public Library()
        {

        }

        public void AddBook()
        {
            book = new Book();
            bookCounter++;

            //book class method
            book.InputBookData();
            books.Add(book);

            using (StreamWriter sw = new StreamWriter(filePath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(book.ID + ";" + book.Name + ";" + book.Author + ";" + book.YearOfPublishing + ";");
            }
        }

        public void ChangeBookInformation()
        {
            Console.WriteLine("Input book ID:");
            uint bookID = Convert.ToUInt32(Console.ReadLine());

            int index = books.IndexOf(books.Find(item => item.ID == bookID));
            Console.WriteLine("Book information for changing:");
            Console.WriteLine("ID: " + books[index].ID + " Author: " + books[index].Author + " Name: " +
                    books[index].Name + " Year: " + books[index].YearOfPublishing);

            Console.WriteLine("Input the book name:");
            books[index].Name = Console.ReadLine();

            Console.WriteLine("Input the book author:");
            books[index].Author = Console.ReadLine();

            Console.WriteLine("Input the year of book publishing:");
            books[index].YearOfPublishing = Console.ReadLine();

        }

        public void DeleteBook()
        {
            Console.WriteLine("Input book ID:");
            uint bookID = Convert.ToUInt32(Console.ReadLine());

            int index = books.IndexOf(books.Find(item => item.ID == bookID));
            Console.WriteLine("Deleted book:");
            Console.WriteLine("ID: " + books[index].ID + " Author: " + books[index].Author + " Name: " +
                    books[index].Name + " Year: " + books[index].YearOfPublishing);
        }

        public void ShowBooks()
        {
            foreach(Book bookElement in books)
            {
                Console.WriteLine("ID: " + bookElement.ID + " Author: " + bookElement.Author + " Name: " + 
                    bookElement.Name + " Year: " + bookElement.YearOfPublishing);
               
            }
        }

        public void AddReader()
        {

        }

        public void ChangeReaderInformation()
        {

        }

        public void DeleteReader()
        {

        }

        public void ShowReaders()
        {

        }

        public void BookStartRenting()
        {

        }

        public void BookReturn()
        {

        }

    }
}
