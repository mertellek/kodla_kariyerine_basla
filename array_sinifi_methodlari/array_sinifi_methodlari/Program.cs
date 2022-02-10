using System;

namespace array_sinifi_methodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayidizisi = { 23, 12, 86, 72, 3, 11, 17 };

            Console.WriteLine("***Sırasız Liste***");
            foreach (var sayi in sayidizisi) Console.Write(sayi + " " );

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***Sıralı Liste***");
            Array.Sort(sayidizisi);
            foreach (var sayi in sayidizisi) Console.Write(sayi + " ");

            //Clear
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***Array Clear***");

            Array.Clear(sayidizisi, 2, 2);
            foreach (var sayi in sayidizisi) Console.Write(sayi + " ");

            //Reverse
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***Reverse***");

            Array.Reverse(sayidizisi);
            foreach (var sayi in sayidizisi) Console.Write(sayi + " ");

            //Index Of
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***Index Of***");

            Console.WriteLine("23 Sayısı Dizinin " + (Array.IndexOf(sayidizisi, 23)) + ". Indeksi." );

            //Resize
            Console.WriteLine();
            Console.WriteLine("***Resize***");

            Array.Resize<int>(ref sayidizisi, 8);
            sayidizisi[7] = 99;
            foreach (var sayi in sayidizisi) Console.Write(sayi + " ");

            Console.ReadKey();
        }
    }
}
