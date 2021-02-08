using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri customer)
        {
            Console.WriteLine("Congratulations! New customer added: " + customer.Id + "  " + customer.Name);
        }

        public void List(Musteri[] customers)
        {
            foreach (Musteri customer in customers)
            {
                Console.WriteLine("Id: " + customer.Id);
                Console.WriteLine("TCNo: " + customer.TCNo);
                Console.WriteLine("BirthYear: " + customer.BirthYear);
                Console.WriteLine("Name: " + customer.Name);
                Console.WriteLine("Surname: " + customer.Surname);
                Console.WriteLine("AccountNumber: " + customer.AccountNumber);
                Console.WriteLine( );
            }
        }

        public void Delete(Musteri customer)
        {
            Console.WriteLine("Congratulations! Customer deleted: " +customer.Id + "  " + customer.Name);
        }

    }
}
