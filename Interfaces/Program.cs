using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Engin",
                LastName = "Demirog",
                Address = "Ankara"

            };
            Student student = new Student
            {
                Id = 1,
                FirstName = "Derin",
                LastName = "Demirog",
                Departmant = "Computer Sciences"

            };
            manager.Add(customer);
           
            Console.WriteLine();

        }
        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; } 
            string LastName { get; set; }
        }
        class Customer : IPerson
        {
            public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Address { get; set; }
        }
        class Student : IPerson
        {
            public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Departmant { get; set; }
        }
        class PersonManager
        {
            public  void Add(Customer customer)
            {
                Console.WriteLine(customer.FirstName);
                
            }
        }
    }
}
