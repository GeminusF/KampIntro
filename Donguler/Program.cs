using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array-dizi

            //string[] kurs = urunleriGetir(); gercek hayatda boyle

            string[] kurs = new string[] {
                "Yazilim Gelistirici Yetistirme Kamp",
                "Programlamaya baslangic icin temel kurs",
                "Java"
            };


            for (int i = 0; i <kurs.Length; i++)
            {
                Console.WriteLine(kurs[i]);
                         
            }
            // item aliasdi
            foreach (var item in kurs)
            {
                Console.WriteLine(item);
            }


        }
    }
}
