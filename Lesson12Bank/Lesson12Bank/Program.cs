using System;

namespace Lesson12Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            Console.WriteLine("Commands:");
            Console.WriteLine("addcl - add a client");
            Console.WriteLine("deletecl - delete a client");
            Console.WriteLine("changecl - change client information");
            Console.WriteLine("showcl - show clients");
            Console.WriteLine("addcd - add a card");
            Console.WriteLine("deletecd - delete a card");
            Console.WriteLine("showcd - show cards");
            Console.WriteLine("exit - exit the program");

            do
            {
                Console.WriteLine("\nInput command:");
                switch (Console.ReadLine())
                {
                    case "addcl":
                        bank.AddClient();
                        break;
                    case "deletecl":
                        bank.DeleteClient();
                        break;
                    case "changecl":
                        bank.ChangeClientInformation();
                        break;
                    case "showcl":
                        bank.ShowClients();
                        break;
                    case "addcd":
                        bank.AddCard();
                        break;
                    case "deletecd":
                        bank.DeleteCard();
                        break;
                    case "showcd":
                        bank.ShowCards();
                        break;
                    case "exit":
                        return;
                }
            }
            while (true);

            //Console.WriteLine("Hello World!");
        }
    }
}
