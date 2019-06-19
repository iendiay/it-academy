using System;

namespace Lesson11Abstract
{
    abstract class ATM
    {
        private string adress;

        public string Adress
        {
            get
            {
                return adress;
            }

            set
            {
                adress = value;
            }
        }

        public decimal getCash(decimal cash)
        {
            Console.WriteLine("Your cash: " + cash);
            return cash;
        } 
    }

    abstract class ATMPriorbank : ATM
    {
        public decimal getBonus(decimal cash)
        {
            decimal bonusCoefficient = 0.01M;
            decimal cashBonus = cash * bonusCoefficient;
            Console.WriteLine("Your bonus: " + cashBonus);
            return cashBonus;
        }
    }

    class ATMPrior : ATMPriorbank
    {
        
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            ATMPrior atmP = new ATMPrior();

            atmP.Adress = "prospekt Masherova 40";

            Console.WriteLine("Input cash value:");
            decimal cash = Convert.ToDecimal(Console.ReadLine());

            atmP.getCash(cash);
            atmP.getBonus(cash);
            Console.WriteLine(atmP.Adress);

            Console.ReadKey();
        }
    }
}
