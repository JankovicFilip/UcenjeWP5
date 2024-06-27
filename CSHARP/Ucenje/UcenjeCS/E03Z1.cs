using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z1
    {


        public static void Izvedi()
        {

            Console.Write("Molim unesite koliko godina imate: ");
            int godina = int.Parse(Console.ReadLine());

            if (godina >= 18)
            {
                if (godina < 1 || godina > 100)
                {
                    Console.WriteLine("Greska");
                }
                else
                {
                    Console.WriteLine("Vi ste punoljetni!");
                }

                
            }
            else
            {
                Console.WriteLine("Niste punoljetni!");
            }

            Console.WriteLine(godina >= 18 ? "Vi ste punoljetni!" : "Niste punoljetni!");








        }



    }
}
