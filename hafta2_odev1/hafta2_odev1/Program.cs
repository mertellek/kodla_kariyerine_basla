using System;

namespace hafta2_odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Adınızı Giriniz: ");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Hoşgeldiniz " + name + " " + surname + ".");
            Console.ReadKey();

        }
    }
}
