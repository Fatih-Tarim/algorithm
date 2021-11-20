using System;
using System.Collections.Generic;
using System.Text;

namespace tekCift
{
    public class Sayi
    {
        /// <summary>
        /// Parametre olarak aldığı sayı tek mi cift mi
        /// </summary>
        /// <param name="n">Sayi</param>
        /// <returns>Tek ise tru aksi durumda false</returns>

        public static bool tekMi(int n)
        {
            if (n % 2 == 1) return true;
            return false;
        }

        /// <summary>
        /// Parametre olarak aldığı sayinin cift olduğunu kontrol eder
        /// </summary>
        /// <param name="n">Sayi</param>
        /// <returns>n değeri cift ise true aksi durumda false</returns>

        public static bool ciftMi(int n)
        {
            if (n%2==0)
            
                return true;
            return false;
        }
	}

    
}
