using System;
using System.Linq;

namespace Var
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 10; // Implicitly typed.
            int y = 10; // Explicitly typed.

            string[] meyveler = {"Apple","Banana","Pear","Peach"};
            var meyve = from m in meyveler
                        where m[0] == 'A'
                        select m;

            foreach (var m in meyve)
                Console.WriteLine(m);
        }
    }
}
