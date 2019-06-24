using System;
namespace Lesson12Bank
{
    public class Client : Person
    {
        private uint _id;
        private uint _numberOfCards;

        public Client()
        {
            _id = 0;
            _numberOfCards = 0;
        }

        public uint ID
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

        public uint NumberOfCards
        {
            get
            {
                return _numberOfCards;
            }

            set
            {
                _numberOfCards = value;
            }
        }


        public void ShowAccountInfo()
        {

        }


    }
}
