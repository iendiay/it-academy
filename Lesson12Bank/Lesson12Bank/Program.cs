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
            Console.WriteLine("addcard - add a card");
            Console.WriteLine("deletecard - delete a card");
            Console.WriteLine("showcard - show cards");
            Console.WriteLine("exit - exit the program");

            do
            {
                Console.WriteLine("\nInput command:");
                switch (Console.ReadLine())
                {
                    case "addcl":
                        bank.AddClient();
                        break;
                    case "delcl":
                        bank.DeleteClient();
                        break;
                    case "chcl":
                        bank.ChangeClientInformation();
                        break;
                    case "shcl":
                        bank.ShowClients();
                        break;
                    case "addcd":
                        bank.AddCard();
                        break;
                    case "delcd":
                        bank.DeleteCard();
                        break;
                    case "shcd":
                        bank.ShowCards();
                        break;
                    case "putsum":
                        cli
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
