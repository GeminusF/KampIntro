using System;

namespace OOP1
{
    class Program
    {   //intaniol programming evvel ehtiyaclariniz sanki varmis kimi kodlanilir sonra doldurulur
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; 
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            // Product product =  new Product{ } ; evvel c#da deyil idi zamanla c# gelib
            Product product2 = new Product { 
                Id = 2 ,
                CategoryId = 5 , 
                UnitsInStock = 5 , 
                UnitPrice = 35 ,
                ProductName = "Kalem"
            };

            //PascalCase   //camelCase
            //case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Add(product2);
            
        }   

    }
}
