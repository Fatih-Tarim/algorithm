using System;

namespace switch_case_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int caseSwitch = rnd.Next(1, 4);

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("case 1");
                    break;
                case 2:
                case 3:
                    Console.WriteLine($"Case {caseSwitch}");
                    break;
                default:
                    Console.WriteLine($"Beklenmeyen durum {caseSwitch}");
                    break;
            }
        }
    }
}
