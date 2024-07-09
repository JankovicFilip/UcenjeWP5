using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E12Rekurzija
    {
        // rekurzija je kada metoda poziva samu sebe
        // uz uvijet prekida rekurzije
        public static void Izvedi()
        {

            // Metoda(); ovo producira StackOverflow exception
            Console.WriteLine(Zbroji(100));
        }


        private static void Metoda()
        {
            Metoda();
        }

        private static int Zbroji(int broj)
        {
            if(broj == 1)
            {
                return 1;               
            }
            return broj + Zbroji(broj - 1);
        }
    }
}
