using System;
namespace Lesson12Bank
{
    public class Card
    {
        private uint _id;
        private string _type;
        private string _currency;
        private decimal _sum;
        private uint _clientID;

        public string ID
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }

        public string Currency
        {
            get
            {
                return _currency;
            }

            set
            {
                _currency = value;
            }
        }

        public decimal Sum
        {
            get
            {
                return _sum;
            }

            set
            {
                _sum = value;
            }
        }

        public uint ClientID
        {
            get
            {
                return _clientID;
            }

            set
            {
                _clientID = value;
            }
        }

        public Card()
        {

        }

        public void ShowCardInfo()
        {

        }

        public void PutMoney(decimal cash)
        {
            _sum = _sum + cash;
        }

        public decimal GetMoney(decimal cash)
        {
            if (cash > _sum)
            {
                _sum = _sum - cash;
                return cash;
            }
            else
            {
                return -1;
            }
        }

    }
}
