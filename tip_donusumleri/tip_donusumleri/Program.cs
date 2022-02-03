using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //İmplicit Conversion (Bilinçsiz Dönüşüm)
            Console.WriteLine("**********İmplicit Conversion**********");
            
            byte a = 5;
            sbyte b = 10;
            short c = 15;
            int d = a + b + c;
            Console.WriteLine("d= " + d);

            long e = d;
            Console.WriteLine("e= " + e);

            float f = e;
            Console.WriteLine("f= " + f);

            string g = "Mert";
            char h = 'E';
            char i = ' ';
            char j = '.';
            object k = g + i + h + j + i + f;
            Console.WriteLine("k= " + k);

            //Explicit Conversion (Bilinçli Dönüşüm)
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("**********Explicit Conversion**********");

            int L = 5;
            byte m = (byte)L;
            Console.WriteLine("m= " + m) ;

            float n = 15.27f;
            byte o = (byte)n;
            Console.WriteLine("o= " + o);

            //ToString Methodu
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("**********ToString**********");

            int p = 15;
            string r = p.ToString();
            Console.WriteLine("r= " + r);

            string s = 33.3f.ToString();
            Console.WriteLine("s= " + s);

            //System Convert
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("**********System Convert**********");

            string t = "15", u = "20";
            int v, w, x;

            v = Convert.ToInt32(t);
            w = Convert.ToInt32(u);
            x = v + w;
            Console.WriteLine("Toplam= " + x);

            ParseMethod();
        }

        public static void ParseMethod()
        {
            //Parse Method
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("**********Parse Method**********");

            string metin1 = "18", metin2 = "10,88";
            int sayi1;
            double sayi2;

            sayi1 = Int32.Parse(metin1);
            sayi2 = Double.Parse(metin2);

            Console.WriteLine("Sayi1= " + sayi1);
            Console.WriteLine("Sayi2= " + sayi2);

            Console.ReadKey();

        }
    }
}
