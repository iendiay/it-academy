using System;
using System.Collections.Generic;

namespace Lesson9LibraryConsole
{
    public class Library
    {
        List<Book> books = new List<Book>();
        List<Reader> readers = new List<Reader>();
        private Book book;
        private Reader reader;

        private static uint bookCounter = 0; 

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
            book.InputBookData();
            books.Add(book);
        }

        public void ChangeBookInformation()
        {

        }

        public void DeleteBook()
        {

        }

        public void ShowBooks()
        {
            foreach(object bookElement in books)
            {
                //Console.WriteLine(bookElement.);
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
