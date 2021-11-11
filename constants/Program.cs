using System;

namespace constants
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //static ile const birlikte kullanılamaz
            //static const int c = 23;


            //Atamaların her iki tarafı sabit olmalı !
            // --> Yanlış Kullanım <--
            // int sayi1 = 3;
            //const int c1 = 7 + sayi1;

            //const sabiti kullanıldığı yerde değeri verilmelidir
            // --> Yanlış Kullanım <--

            //const int a;
            //a = 2;   

        }

        readonly int a;
        public Program()
        {
            a = 3;

        }
    }
}
