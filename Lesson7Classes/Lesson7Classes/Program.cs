using System;

namespace Lesson7Classes
{
    //parent class
    class Person
    {
        int age;
        string dateOfBirth;
        public string name;
        string adress;
        const int quantity = 1;

        //constructor
        public Person()
        {
            age = 0;
            dateOfBirth = " ";
            name = "Name";
            adress = "Adress";
        }

        //overrided constructor
        public Person(int a, string n, string ad)
        {
            age = a;
            name = n;
            adress = ad;
        }

        public void setAge(int a)
        {
            age = a;
        }
        //overrided setAge
        public void setAge(int a, string dob)
        {
            age = a;
            dateOfBirth = dob;
        }

        public int getAge()
        {
            return age;
        }

        //overrided virtual metod
        public virtual void printInfo()
        {
            Console.WriteLine($"Age: {age}; DOB: {dateOfBirth} Name: {name}; Adress: {adress}; Quantity: {quantity}");
        }
    }


    //child class
    class Employee : Person
    {
        public string position;
        private double salary;

        //overrided virtual method
        public override void printInfo()
        {
            Console.WriteLine($"Age: {getAge()}; Name: {name}; Position: {position}; Salary: {salary}");
        }


    }

    //indexation
    class People
    {
        Person[] data;

        public People()
        {
            data = new Person[5];
        }

        public Person this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        { 
            Person p1 = new Person();

            Employee e1 = new Employee();

            p1.name = "John Smith";
            e1.name = "Jack Sparrow";

            e1.position = "artist";
            e1.printInfo();

            p1.setAge(25);
            e1.setAge(27, "11.11.1991");

            e1.printInfo();
            p1.printInfo();

            Person p2 = new Person(22, "Polly Nom", "Adress222");
            p2.setAge(30, "01.01.1989");
            p2.printInfo();

            Person p3 = new Person();
            p3.printInfo();

            int agePerson2;
            agePerson2 = p2.getAge();
            Console.WriteLine(agePerson2);

            //indexation
            People people = new People();
            people[0] = new Person(100, "Martin Luter", "Adress 4-44");
            people[1] = new Person(100, "Isaac Newton", "London");
            people[1].printInfo();



            Employee e2 = new Employee();
            e2.printInfo();



        }
    }
}
