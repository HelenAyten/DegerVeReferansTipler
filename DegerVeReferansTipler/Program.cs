using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 nedir? 30
            //int decimal float double bool değertip
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 15, 25, 35 };
            sayilar1 = sayilar2;
            sayilar1[0] = 99;
            //sayilar1[0] elemanı nedir? 99 referans olduğundan
            //array,class, interface ler referans tiplerdir.
            Console.WriteLine(sayilar1[0]);
         }
    }
}
