using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmeni = "Engin Demirog";
            kurs1.BaxisNisbeti = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmeni = "Kerem Varis";
            kurs2.BaxisNisbeti = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmeni = "Berkay Bilgin";
            kurs3.BaxisNisbeti = 80;

            //Yeni icinde class Kurs nesnesini barindiran bir array tanimladim
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};

            foreach (var item in kurslar)
            {
                item.print();
            }
        }
    }
    //sanki oz veri tipimizi yaziriq
    class Kurs
    {
        //kursun 3 ozelliyi var property ozellik
        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int BaxisNisbeti { get; set; }

        public void print()
        {
            Console.WriteLine(KursAdi + " : " + Egitmeni + " " + BaxisNisbeti);
        }

    }
}
