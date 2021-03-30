using System;

namespace DegerVeReferans
{
    class Program
    {   //yazilimin en vacib xususiyyeti davamlilqidir ,yasayan bir organizmadir yazilim.Hic bir yazilim yoxduki yazilandan sonra deyisiklik alsin
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2; //sayi1in degeri esittir sayi2nin degeri
            sayi2 = 65;
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30};
            int[] sayilar2 = new int[] { 100, 200, 300};
            sayilar1 = sayilar2; //sayilar1in referans nom. beraberdir sayilar2in referans nom.
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);

            //deger tipler :
            // int , decimol , float , double , bool(0 ,1)
            // referans tipler:
            // array , class , interface 

            //deger tipler stackde olur

            // referans tipler hem stack hem heapde. sayilar1 deyende stackde sayilar 1
            //yaranir. new demek  heapde alan olustur ve degerleri ora yaz demekdi [10,20,30]
            // heapde de adress var

        }
    }
}
