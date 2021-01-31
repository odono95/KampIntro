using System;

namespace Constructors
{//constructors work when we first call the code
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {Id=1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara"};

            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");

            Console.WriteLine(customer2.FirstName);
        }
    }

    class Customer
    {
        //default constructor always works in the background
        public Customer()
        {

        }
        //overloading the constructor to use it in another way
        public Customer(int id, string firstName, string lastName, string city) //ctor
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
