using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Fereh", "Seref", "Rzey" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //new dediyimiz an 5  elemanli bos array olusur ona gore 4cu indexdeki eleman Idris olarken 0ci indexdeki eleman bosdur
            //isimler = new string[5];
            //isimler[4] = "Idris";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> {"Fereh" , "Seref" , "Rzey"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Idris");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
