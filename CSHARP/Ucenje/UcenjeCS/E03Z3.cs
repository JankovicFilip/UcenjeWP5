using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z3
    {


        public static void Izvedi()
        {
            Console.Write("Molim unesite cijeli broj: ");
            int broj = int.Parse(Console.ReadLine());

            Console.Write("Molim unesite cijeli broj: ");
            int broj2 = int.Parse(Console.ReadLine());


            if (broj > broj2)
            {
                Console.WriteLine(broj2);
            }
            else
            {
                Console.WriteLine(broj);
            }

            Console.WriteLine(broj > broj2 ? broj2 : broj);






        }



    }
}
