using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleLambdaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Customer List");
            Console.WriteLine("--------------");

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer("Amba", "Kanwar"));
            customers.Add(new Customer("Raj", "Somarouthu"));
            customers.Add(new Customer("Rohit", "Naredla"));
            customers.Add(new Customer("Sai", "Madala"));

            foreach (Customer cust in customers)
            {
                Console.WriteLine(cust);
            }

            Console.WriteLine("\nSorted by First Name");
            Console.WriteLine("---------------------");

            customers.Sort(SortByFirstName);

            foreach (Customer cust in customers)
            {
                Console.WriteLine(cust);
            }

            Console.WriteLine("\nSorted by Last Name");
            Console.WriteLine("-------------------");

            customers.Sort(SortByLastName);

            foreach (Customer cust in customers)
            {
                Console.WriteLine(cust);
            }

            Console.WriteLine("\nSorted by Last Name using Lambda expressions");
            Console.WriteLine("----------------------------------------------");

            customers.Sort((lhs, rhs) =>
            {
                if (lhs == null) return -1;
                if (rhs == null) return 1;
                return lhs.LastName.CompareTo(rhs.LastName);
            });

            foreach (Customer cust in customers)
            {
                Console.WriteLine(cust);
            }
            
            Console.WriteLine("\nSorted by First Name using LINQ Query");
            Console.WriteLine("----------------------------------------------");

            foreach(Customer c in 
            customers.OrderBy(c => c.FirstName))
            {
                Console.WriteLine(c.ToString());
            }


        }

        private static int SortByFirstName(Customer lhs, Customer rhs)
        {
            if (lhs == null) return -1;
            if (rhs == null) return 1;
            return lhs.FirstName.CompareTo(rhs.FirstName);
        }

        private static int SortByLastName(Customer lhs, Customer rhs)
        {
            if (lhs == null) return -1;
            if (rhs == null) return 1;
            return lhs.LastName.CompareTo(rhs.LastName);
        }
    }

}
