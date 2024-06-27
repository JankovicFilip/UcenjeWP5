using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E02VarijableTipoviPodataka
    {

        public static void Izvedi()
        {
            //deklaracija varijable
            int i;

            //dodijeljivanje vrijednosti
            i = 7;

            //koristenje variable
            Console.WriteLine(i);

            Console.Write("Unesi broj: ");
            int broj =int.Parse(Console.ReadLine());
            Console.WriteLine(broj + 1);

        }


    }
}
