using System;

namespace if_else_2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int m = 9;
            int n = 7;
            int p = 5;

            // && and 
            // || or 
            if (m>=n && m>=p)
            {
                Console.WriteLine("En buyuk m");
            }
             if (m>=n && !(n>=m))
            {
                Console.WriteLine("En buyuk m 2");
            }

            if (m>n || m>p)
            {
                Console.WriteLine("m en kucuk degil !");
            }

            m = 4;

            if (!(m>=n || m>=p))
            {
                Console.WriteLine("m artik en kucuk");
            }


        }
    }
}
