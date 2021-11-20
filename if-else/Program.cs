using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir karakter giriniz: ");
            char ch = (char)Console.Read();
            int sayi = 1;

            if (char.IsUpper(ch)) 
            {
                Console.WriteLine("Girilen karakter büyük bir karakterdir.");
            }
            else if (char.IsLower(ch))
            {
                Console.WriteLine("Girilen karakter küçük bir karakterdir.");
            }
            else if (char.IsDigit(ch))
            {
                Console.WriteLine("Girilen karakter bir rakamdır.");
            }
            else
            {
                Console.WriteLine("Karakter bir alfanumerik karakter değildir.");
            }
            
        }
    }
}
