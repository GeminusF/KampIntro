using System;

namespace OOP2
{
    class Program
    {   //abstraction(soyutlama) sektorde sizi deyerli yapacakdir
        static void Main(string[] args)
        {
            //Fereh Feyzullayev
            Individual customer1 = new Individual();
            customer1.Id = 1;
            customer1.CustomerId = "12345";
            customer1.CustomerName = "Fereh";
            customer1.CustomerSurname = "Feyzullayev";
            customer1.TcNo = "000000000";

            //Kodlama.io Company
            Corporate customer2 = new Corporate();
            customer2.Id = 2;
            customer2.CustomerId = "67890";
            customer2.CorporationName = "KODLAMA.IO";
            customer2.TaxNo = "99999";


            //Gercek - Tuzel(Hansisa qurum , sirket) bunlar bir birine oxsuyur deye bir birinin yerine
            //qoyula bilmez.Bunlar ikiside musteridi amma bunlar bir-birine yerine asla konulamaz
            //musteri1.CustomerType demek de olmaz buda xetalidir . DATALAR QARISIR


            //SOLID - l herifi

            // harda new gordunse referans.no kimi oxu Customer hem Individualin hem de Corporate musteri nosunu
            //saxlaya bilir
            Customer customer3 = new Individual();
            Customer customer4 = new Corporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
            // Olay tamamen referans tip
        }
    }
}
