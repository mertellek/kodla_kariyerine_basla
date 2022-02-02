using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atama ve İşlemli Atamalar
            Console.WriteLine("**********Atama İşlemleri**********");
            int x = 2, y = 3;

            y = y + 2;
            Console.WriteLine(y);

            y += 2;
            Console.WriteLine(y);

            y *= 3;
            Console.WriteLine(y);

            x /= 2;
            Console.WriteLine(x);

            // Mantıksal Operatörler ( // , && , ! )
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("**********Mantıksal Operatörler**********");

            bool isSuccess=false, isCompleted=false;
            Console.WriteLine("Öğrenci sınavlarında başarılı mı?");
            Console.WriteLine("Başarılı ise lütfen 1'e, değilse herhangi bir tuşa basınız: ");
            string success_tus = Console.ReadLine();

            if (success_tus == "1") { isSuccess = true; }
            else { isSuccess = false; }

            Console.WriteLine("Öğrenci ödevlerininin hepsini tamamladı mı?");
            Console.WriteLine("Tamamladı ise lütfen 1'e, tamamlamadıysa herhangi bir tuşa basınız: ");
            string completed_tus = Console.ReadLine();

            if (completed_tus == "1") { isCompleted = true; }
            else { isCompleted = false; }

            if (isSuccess && isCompleted)
            {
                Console.WriteLine("Başarılarının devamını dilerim!");
            }
            else if (isSuccess && !isCompleted)
            {
                Console.WriteLine("Zeki ama çalışmıyor :) ");
            }
            else if (!isSuccess && isCompleted)
            {
                Console.WriteLine("Herkes her derste başarılı olmak zorunda değil, belki de yeteneğin başka alanladadır :) ");
            }
            else
            {
                Console.WriteLine("Yarın velin gelsin");
            }

            // İlişkisel Operatörler ( < , > , <= , >= , ==, != )
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("**********İlişkisel Operatörler**********");

            int a = 3, b = 4;
            bool sonuc = a < b;
            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);



            //Aritmetik Operatörler (/ , *, +, -)
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("**********Aritmetik Operatörler**********");

            int sayi1 = 5, sayi2 = 10;
            int sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sonuc1-sayi1;
            Console.WriteLine(sonuc1);
            sonuc1 = sonuc1+=15;
            Console.WriteLine(sonuc1);


            // Mod Alma ( % )
            int sonuc2 = sonuc1 % 5;
            Console.WriteLine("Mod: " + sonuc2);

            Console.ReadKey();
        }
    }
}
