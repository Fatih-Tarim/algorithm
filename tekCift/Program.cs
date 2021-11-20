using System;

namespace tekCift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayi giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (Sayi.tekMi(n))
                Console.WriteLine("Girilen sayi = {0} tek bir sayidir.", n);
            if (Sayi.ciftMi(n))
                Console.WriteLine("Girilen sayi cift");
            
            
        }
    }
}

