using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03UvjetnoGrananjeIf
    {

        public static void Izvedi()
        {

            int i = 7;

            bool uvjet = i == 8;

            Console.WriteLine(uvjet);

            // if radi sa bool tipom podatka


            if (uvjet) {

                Console.WriteLine("Vrijednost varijable i je 8");
            
            }


            // ovo nikada ne pisati
            //if (uvjet == true) { 
            //
            //
            //}

            //najcesca sintaksa
            if (i == 8) { 
            
            }

            //if ima i else granu
            if (i > 10)
            {
                Console.WriteLine("i je veci od 10");
            }
            else
            {
                Console.WriteLine("i nije veci od 10");
            }

            //if ne more imati {} ako se if ili else odnose samo na jednu liniju
            // nije najbolja praksa
            if (i > 10) Console.WriteLine("i je veci od 10");
            else Console.WriteLine("i nije veci od 10");

            // puna sintaksa if naredbe
            int b = 2;
            if (b == 1)
            {
                Console.WriteLine("Ne moze");
            }
            else if (b > 5)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Ostalo");
            }

            // operatori & i &&
            // & uvijek provjerava oba uvjeta
            // && ukoliko prvi uvjet nije zadovoljen drugi se niti ne gleda

            int x = 2, y = 1;
            if (x == 1 && y == 1)
            {
                Console.WriteLine("x i y su 1");
            } 

            // operatori | || 
            // | provjerava oba uvjeta
            // || ukoliko je prvi uvjet zadovoljen ne gleda se drugi

            if (x > 1 || y == 0)
            {
                Console.WriteLine("ako je prvi uvjet zadovoljen ulazi se u if");
            }



        }



    }
}
