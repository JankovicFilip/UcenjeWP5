using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E09ForEachPetlja
    {
        public static void Izvedi()
        {
            string grad = "Osijek";

            // svaki znak ispisati jedno ispod drugog

            for(int i = 0; i < grad.Length; i++)
            {
                Console.WriteLine(grad[i]);
            }

            Console.WriteLine("************************");

            foreach (char znak in grad)
            {
                Console.WriteLine(znak);

            }

            // ovo ne moze

            // int broj = 5844;
            // foreach(int b in broj)
            // {
            // Console.WriteLine(b);
            // }

            Console.WriteLine("************************");
            float[] brojevi = { 2, 3, 4, 5.3f, 6, 3, 2, 2 };
            float suma = 0;
            foreach(var e in brojevi) // e kao element, posto je var (variable)
            {
                Console.WriteLine(e);
                suma += e;
            }
            Console.WriteLine(suma);

            Console.WriteLine("************************");




        }





    }
}
