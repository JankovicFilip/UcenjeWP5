using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E08DoWhilePetlja
    {

        public static void Izvedi()
        {

            // u do while se obavezno ulazi barem jednom
            // radi sa bool

            do
            {
                Console.WriteLine("Edunova!");

            } while (false);

            int i = 0;
            do
            {
                Console.WriteLine(i++);

            } while (i < 10);

            // sve ostalo vrijeda kao i za for i while, break, continue, ugnjezdivanje itd.











        }
    }
}
