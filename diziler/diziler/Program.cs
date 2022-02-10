using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi Tanımlama

            string[] renkler = new string[5];

            string[] hayvanlar = {"Kedi","Köpek","Eşek","Horoz"};

            int[] rakamlar;
            rakamlar = new int[5];
            
            //Dizilere Değer Atama
            rakamlar[0] = 1;
            rakamlar[4] = 5;

            renkler[4] = "Turuncu";

            Console.Write(rakamlar[0] + " " + renkler[4] + " " + hayvanlar[0]);
            Console.WriteLine();
            Console.WriteLine();
            //Döngülerle Dizi Kullanımı
            //Klavyeden girilen n tane sayının ortalamasını veren program
            Console.Write("Lütfen Dizinin Eleman Sayısını Giriniz: ");
            int n = int.Parse(Console.ReadLine());
            int[] sayidizisi = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Lütfen {0}. Sayıyı giriniz: ",i+1);
                sayidizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayidizisi) toplam += sayi;

            Console.WriteLine("Dizinin Ortalaması: "+ toplam / n);
            Console.ReadKey();
        }
    }
}
