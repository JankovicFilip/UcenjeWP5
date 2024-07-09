using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E11Metode
    {

        public static void Izvedi()
        {
            Console.WriteLine("Hello E11!");

            // poziv privatne metode
            Tip1();
            // mora se poslati paramatar, u ovom slucaju broj
            int broj = 5;
            Tip2(broj);
            Tip2(); // nisam poslao vrijednost pa je uzet zadana vrijednost 2

        }


        // kada nije naveden nacin pristupa je private
        // static je oznaka da se metoda zove na klasi
        // void je oznaka da metoda ne vraca vrijednost
        // tip1 je naziv metode
        // () su parametri metode
        static void Tip1()
        {
            Console.WriteLine("Sadrzaj metode koja ne prima parametar i ne vraca vrijednost");
        }

        // ova metoda prima jedan parametar tipa int
        private static void Tip2(int x = 2) // opcionalni parametri, doda se zadana vrijednost = 2
        {
            Console.WriteLine("Metoda je primila parametar tipa integer s vrijednoscu {0} ",x);
            for(int i = 0; i < x; i++)
            {
                Console.WriteLine(i);
            }

        }

        // method overloading
        
        
    }
}
