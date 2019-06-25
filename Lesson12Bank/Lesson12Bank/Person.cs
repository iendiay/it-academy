using System;
namespace Lesson12Bank
{
    public abstract class Person
    {

        private string _name;
        private string _surname;
        private string _dateOfBirth;
        private string _adress;
        private string _phone;
        private string _email;

        public Person()
        {
            _name = "empty_name";
            _surname = "empty_surname";
            _dateOfBirth = "empty_dateOfBirth";
            _adress = "empty_adress";
            _phone = "empty_phone";
            _email = "empty_email";
        }


        public Person(string name, string surname, string dateOfBirth ,string adress, string phone, string email)
        {
            _name = name;
            _surname = surname;
            _dateOfBirth = dateOfBirth;
            _adress = adress;
            _phone = phone;
            _email = email;
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }

            set
            {
                _surname = value;
            }
        }

        public string DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }

            set
            {
                _dateOfBirth = value;
            }
        }

        public string Adress
        {
            get
            {
                return _adress;
            }

            set
            {
                _adress = value;
            }
        }

        public string Phone
        {
            get
            {
                return _phone;
            }

            set
            {
                _phone = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }
    }
}
