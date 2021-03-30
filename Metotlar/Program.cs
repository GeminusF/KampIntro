using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //methodlar tekrar tekrar kullana bilirliyi(reuseablity) saylagan kod bloklaridi

            //veriler gercek hayatda veri tabanindan ,Api ,excelden , metin dosyasindan
            Product urun1 = new Product();// classin ornegi
            urun1.Adi = "Alma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Qax Almasi";

            Product urun2 = new Product();
            urun2.Adi = "Qarpiz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Sabirabad Qarpizi";

            Product[] urunler = new Product[] {urun1 , urun2 };

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------");
            }

            Console.WriteLine("-------------Metotlar-----------------------");

            // instance - ornek
            // encapsulation

            SebetManager sebet = new SebetManager();
            sebet.Elave(urun1);
            sebet.Elave(urun2);

            sebet.Elave2("Armud", "Yasil", 12 , 10);
            sebet.Elave2("Alma", "Qirmizi", 12 , 9);
            sebet.Elave2("Qarpiz", "Diyarbakir Qarpizi", 12 , 8);
        }
    }
}

//Dont repeat yourself -DRY
//Clean Code temiz kod yazma teknikleri methodlarla ilgili
//Best Practice dogru uygulama teknikleri