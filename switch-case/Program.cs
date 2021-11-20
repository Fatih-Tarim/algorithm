using System;

namespace switch_case
{
    class Program
    {
        public enum Colors {Kirmizi, Yesil, Mavi};
        static void Main(string[] args)
        {
            Colors c = (Colors)(new Random()).Next(0, 3);

            switch (c)
            {
                case Colors.Kirmizi:
                    Console.WriteLine("Color is red");
                    break;
                case Colors.Yesil:
                    Console.WriteLine("Color is green");
                    break;
                case Colors.Mavi:
                    Console.WriteLine("Color is blue");
                    break;
                default:
                    Console.WriteLine("Unknown color");
                    break;
            }


        }
    }
}
