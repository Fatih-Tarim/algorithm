using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // boxing

            int i = 20;
            object o = (object)i; // explicit boxing

            //unboxing

            i *= 2;
            i = (int)o; //cast işlemi

            Console.WriteLine("Değer türü: {0}",i);
            Console.WriteLine("Referans türü: {0}", o);

        }
    }
}
