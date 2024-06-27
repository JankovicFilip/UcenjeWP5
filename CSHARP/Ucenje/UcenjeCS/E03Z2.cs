using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z2
    {


        public static void Izvedi()
        {
            Console.Write("Molim unesite cijeli broj: ");
            int cijeliBroj = int.Parse(Console.ReadLine());

            if (cijeliBroj % 2  == 0 )
            {
                Console.WriteLine("Broj je paran!");
            }
            else
            {
                Console.WriteLine("Broj nije paran!");
            }

            Console.WriteLine(cijeliBroj % 2 == 0 ? "Broj je paran!" : "Broj nije paran!");








        }



    }
}
