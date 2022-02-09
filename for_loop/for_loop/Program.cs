using System;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            for (int i = 1; i <= sayi; i++)
            {
                if (i%2==1)
                {
                    Console.Write(i + " ");
                }
                else
                {

                }               
            }
            Console.WriteLine();

            int tektoplam = 0, cifttoplam = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if (i%2==1)
                {
                    tektoplam += i;
                }
                else
                {
                    cifttoplam += i;
                }
            }
            Console.WriteLine("Tek Sayıların toplamı: " + tektoplam);
            Console.WriteLine("Çift Sayıların toplamı: " + cifttoplam);

            for (int i = 1; i < 10; i++)
            {
                Console.Write(i+" ");
                if (i==5)
                {                   
                    break;
                }
            }
                Console.WriteLine();
            for (int i = 1; i < 10; i++)
            {               
                if (i==5)
                {
                    continue;
                }
                Console.Write(i+" ");
            }

            Console.ReadKey();
        }
    }
}
