using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E07Z2
    {
        public static void Izvedi()
        {
            int unos = 0;
            int suma = 0;

            while (true)
            {
                Console.Write("Unesi broj: ");
                unos = int.Parse(Console.ReadLine());
                if (unos == -1)
                {
                    break;
                }

                suma += unos;
                
                

            }
            Console.WriteLine(suma);
        }



    }
}
