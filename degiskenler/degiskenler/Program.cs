using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 10;
            sbyte sb = 10;

            Console.WriteLine("byte türünde değerler toplamı: ");
            Console.WriteLine(b + sb);

            short s = 10;
            ushort us = 10;
            Console.WriteLine("short türünde değerler toplamı: ");
            Console.WriteLine(s+us);

            int i = 10;
            Int16 i16 = 10;
            Int32 i32 = 10;
            Int64 i64 = 10;
            uint ui = 10;
            Console.WriteLine("int türünde değerler toplamı: ");
            Console.WriteLine(i + i16 + i32 + i64 + ui);

            long l = 10;
            ulong ul = 10;
            Console.WriteLine("long değeri: ");
            Console.WriteLine(l);
            Console.WriteLine("ulong değeri: ");
            Console.WriteLine(ul);

            float f = 10;
            double d = 10;
            decimal de = 10;
            Console.WriteLine("float + double: ");
            Console.WriteLine(f+d);
            Console.WriteLine("decimal değeri: ");
            Console.WriteLine(de);

            char ch = '2';
            string str = "Mert";
            Console.WriteLine(ch + ". " + str);

            bool b1 = true;
            Console.WriteLine("bool1 değeri: "+ b1);
            bool b2 = false;
            Console.WriteLine("bool2 değeri: "+ b2);

            DateTime dt = DateTime.Now;
            Console.WriteLine("Zaman: "+dt);

            string str1 = string.Empty;
            str1 = "Mert Ellek";
            string ad = "Mert";
            string soyad = "Ellek";
            string tamad = ad + " " + soyad;
            Console.WriteLine(tamad);

            string str20 = "20";
            int int20 = 20;
            string yenideger = str20 + int20.ToString();
            Console.WriteLine("string türünde 20 + 20= " + yenideger);
            int yenideger2 = Convert.ToInt32(str20) + int20;
            Console.WriteLine("int türünde 20 + 20= " + yenideger2);
            int yenideger3 = int20 + int.Parse(str20);
            Console.WriteLine("int türünde 20 + 20= " + yenideger3);

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(datetime2);



            Console.ReadKey();
        }
    }
}
