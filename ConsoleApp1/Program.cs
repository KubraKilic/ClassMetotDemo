using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri customer1 = new Musteri();
            customer1.Id = 1;
            customer1.TCNo = "83612937451";
            customer1.BirthYear = 1990;
            customer1.Name = "Sevgi";
            customer1.Surname = "KAYA";
            customer1.AccountNumber = 24354679;

            Musteri customer2 = new Musteri();
            customer2.Id = 2;
            customer2.TCNo = "24673875412";
            customer2.BirthYear = 1992;
            customer2.Name = "Okan";
            customer2.Surname = "YILDIRIM";
            customer2.AccountNumber = 22864511;

            Musteri customer3 = new Musteri();
            customer3.Id = 3;
            customer3.TCNo = "39441692353";
            customer3.BirthYear = 1995;
            customer3.Name = "Yıldız";
            customer3.Surname = "SEVER";
            customer3.AccountNumber = 86901325;

            Musteri customer4 = new Musteri();
            customer4.Id = 4;
            customer4.TCNo = "67342611245";
            customer4.BirthYear = 1988;
            customer4.Name = "Yavuz";
            customer4.Surname = "TEKİN";
            customer4.AccountNumber = 13869021;

            Musteri[] customers = new Musteri[] { customer1, customer2, customer3, customer4 };


            MusteriManager customerManager = new MusteriManager();

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
            Console.WriteLine();

            customerManager.List(customers);
            Console.WriteLine();

            customerManager.Delete(customer1);
            customerManager.Delete(customer2);
            customerManager.Delete(customer3);
            customerManager.Delete(customer4);

        }
    }
}
