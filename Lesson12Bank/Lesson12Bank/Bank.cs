using System;
using System.Collections.Generic;

namespace Lesson12Bank
{
    public class Bank
    {
        List<Client> clients = new List<Client>();
        List<Card> cards = new List<Card>();

        private Client _client;
        private Card _card;

        private const string filePathClients = @"Clients.txt";
        private const string filePathCards = @"Cards.txt";

        public Bank()
        {

        }

        public void AddClient()
        {
            _client = new Client();
            //clientsCounter++;

            /*
            book.InputBookData();
            books.Add(book);

            using (StreamWriter sw = new StreamWriter(filePath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(book.ID + ";" + book.Name + ";" + book.Author + ";" + book.YearOfPublishing + ";");
            }
            */
        }

        public void DeleteClient()
        {

        }

        public void ChangeClientInformation()
        {

        }

        public void ShowClients()
        {

        }

        public void AddCard()
        {

        }

        public void DeleteCard()
        {

        }

        public void ShowCards()
        {

        }

    }
}
