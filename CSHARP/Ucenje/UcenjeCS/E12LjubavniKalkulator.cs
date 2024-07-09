using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E12LjubavniKalkulator
    {
        public static void Izvedi()
        {
            string prvoIme = UnesiIme("Unesi prvo ime: ");
            string drugoIme = UnesiIme("Unesi drugo ime: ");
        }

        static string UnesiIme(string poruka)
        {
            string ime;
            do
            {
                Console.Write(poruka);
                ime = Console.ReadLine().Trim();

                if (ime.Length == 0)
                {
                    Console.WriteLine("Niste unijeli ime!");
                    continue;
                }
                return ime;

            } while (true);

            Console.WriteLine("Unijeli ste: >{0}<", ime);




        }



            


        


    }
}
