using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //While
            //(1den başlayıp girilen sayıya kadar ortalama hesaplayan program

            Console.Write("Bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int i = 1, toplam = 0;
            while (i<=sayi)
            {               
                toplam += i;
                i++;
            }

            Console.WriteLine("Ortalama: " + toplam/sayi);

            //A'dan Z'ye kadar olan tüm harfleri yazdırır
            Console.WriteLine(" ");
            Console.Write("A'dan Z'ye Kadar Olan Harfler: ");
            char harf = 'A';
            while (harf<='Z')
            {
                Console.Write(harf + " ");
                harf++;
            }

            //Foreach
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.Write("Arabalar Dizisi: ");

            string[] arabalar = { "BMW", "Ford", "Opel", "Nissan" };
            foreach(var araba in arabalar)
            {
                Console.Write(araba+" ");
            }
            Console.ReadKey();
        }
    }
}
