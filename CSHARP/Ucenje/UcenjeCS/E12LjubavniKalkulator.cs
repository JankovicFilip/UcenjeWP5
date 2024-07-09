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
            string prvoIme = UnesiIme("Unesi prvo ime: ").ToUpper();
            string drugoIme = UnesiIme("Unesi drugo ime: ").ToUpper();
            Console.WriteLine("Unijeli ste {0} i {1}.", prvoIme, drugoIme);
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

                bool isValid = true;
                foreach (char c in ime)
                {
                    if (!char.IsLetter(c))
                    {
                        isValid = false;
                        break;
                    }
                }

                if (!isValid)
                {
                    Console.WriteLine("Ime može sadržavati samo slova!");
                    continue;
                }

                return ime;

            } while (true);
        }









    }
}
