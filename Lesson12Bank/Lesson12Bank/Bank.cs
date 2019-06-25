using System;
using System.Collections.Generic;
using System.IO;

namespace Lesson12Bank
{
    /*
    enum CardTypes
    {
        Classic,
        Gold,
        Platinum,
    }

    enum CurrencyTypes
    {
        BYN,
        USD,
        EUR
    }
    */

    public class Bank
    {
        List<Client> clients = new List<Client>();
        List<Card> cards = new List<Card>();

        private Client _client;
        private Card _card;
        private uint numberOfClients = 0;
        private uint numberOfCards = 0;
        private const string filePathClients = @"Clients.txt";
        private const string filePathCards = @"Cards.txt";

        public Bank()
        {

        }

        public void AddClient()
        {
            _client = new Client();

            Console.WriteLine("Input client information.");
            Console.WriteLine("Name: ");
            _client.Name = Console.ReadLine();
            Console.WriteLine("Surname: ");
            _client.Surname = Console.ReadLine();
            Console.WriteLine("Date of birth: ");
            _client.DateOfBirth = Console.ReadLine();
            Console.WriteLine("Adress: ");
            _client.Adress = Console.ReadLine();
            Console.WriteLine("Phone: ");
            _client.Phone = Console.ReadLine();
            Console.WriteLine("Email: ");
            _client.Email = Console.ReadLine();

           
            numberOfClients++;
            _client.ID = numberOfClients;

            clients.Add(_client);

            using (StreamWriter sw = new StreamWriter(filePathClients, false, System.Text.Encoding.Default))
            {
                foreach (Client clientItem in clients)
                {
                    sw.WriteLine(_client.ID + ";" + _client.NumberOfCards + ";" + _client.Surname + ";" + _client.Name + ";" + 
                                 _client.DateOfBirth + ";" + _client.Adress + ";" + _client.Phone + ";" + _client.Email);
                }

            }

        }

        public void DeleteClient()
        {

            Console.WriteLine("Input client ID: ");
            uint clientID = Convert.ToUInt32(Console.ReadLine());

            int index = clients.IndexOf(clients.Find(item => item.ID == clientID));
            Console.WriteLine("Client for deleting.");

            Console.WriteLine("ID: " + clients[index].ID + "; Number of cards: " + clients[index].NumberOfCards + "; Surname: " + clients[index].Surname + "; Name: " + clients[index].Name +
                                  "; Date of birth: " + clients[index].DateOfBirth + "; Adress: " + clients[index].Adress + "; Phone: " + clients[index].Phone + "; Email: " + clients[index].Email);

            Console.WriteLine("Do you want to delete this client? (yes/no)");
            string answer = Console.ReadLine();

            if(answer == "yes")
            {
                clients.RemoveAt(index);
            }
            else
            {
                return;
            }
        }

        public void ChangeClientInformation()
        {
            using (StreamReader sr = new StreamReader(filePathClients, System.Text.Encoding.Default))
            {

            }

            Console.WriteLine("Input client ID: ");
            uint clientID = Convert.ToUInt32(Console.ReadLine());

            int index = clients.IndexOf(clients.Find(item => item.ID == clientID));
            Console.WriteLine("Client information for changing:");
            Console.WriteLine("ID: " + clients[index].ID + "; Number of cards: " + clients[index].NumberOfCards + "; Surname: " + clients[index].Surname + "; Name: " + clients[index].Name +
                                  "; Date of birth: " + clients[index].DateOfBirth + "; Adress: " + clients[index].Adress + "; Phone: " + clients[index].Phone + "; Email: " + clients[index].Email);

            Console.WriteLine("Input new client information.");
            Console.WriteLine("Name: ");
            clients[index].Name = Console.ReadLine();
            Console.WriteLine("Surname: ");
            clients[index].Surname = Console.ReadLine();
            Console.WriteLine("Date of birth: ");
            clients[index].DateOfBirth = Console.ReadLine();
            Console.WriteLine("Adress: ");
            clients[index].Adress = Console.ReadLine();
            Console.WriteLine("Phone: ");
            clients[index].Phone = Console.ReadLine();
            Console.WriteLine("Email: ");
            clients[index].Email = Console.ReadLine();
        }

        public void ShowClients()
        {
            foreach (Client clientItem in clients)
            {
                Console.WriteLine("ID: " + clientItem.ID + "; Number of cards: " + clientItem.NumberOfCards + "; Surname: " + clientItem.Surname + "; Name: " + clientItem.Name + 
                                  "; Date of birth: " + clientItem.DateOfBirth + "; Adress: " + clientItem.Adress + "; Phone: " + clientItem.Phone + "; Email: " + clientItem.Email);
            }
        }

        public void AddCard()
        {
            _card = new Card();

            Console.WriteLine("Input card information.");
            Console.WriteLine("Type (Classic, Gold, Platinum): ");
            _card.Type = Console.ReadLine();
            Console.WriteLine("Currency (BYN, USD, EUR): ");
            _card.Currency = Console.ReadLine();
            Console.WriteLine("Sum: ");
            _card.Sum = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Client ID: ");
            _card.ClientID = Convert.ToUInt32(Console.ReadLine());

            numberOfCards++;
            _card.ID = numberOfCards;

            cards.Add(_card);

            using (StreamWriter sw = new StreamWriter(filePathCards, false, System.Text.Encoding.Default))
            {
                foreach (Card cardItem in cards)
                {
                    sw.WriteLine(_card.ID + ";" + _client.NumberOfCards + ";" + _client.Surname + ";" + _client.Name + ";" +
                                 _client.DateOfBirth + ";" + _client.Adress + ";" + _client.Phone + ";" + _client.Email);
                }

            }
        }

        public void DeleteCard()
        {

        }

        public void ShowCards()
        {

        }

        public void PutMoney()
        {

        }

        public void GetMoney()
        {

        }

    }
}
