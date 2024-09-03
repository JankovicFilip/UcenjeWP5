using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E15KlasaObjekt
{
    internal class Program
    {

        public static void Izvedi()
        {


            Console.WriteLine("Hello oop!");

            // objekt je pojavnost klase iliti instanca klase

            // Osoba je ime klase
            // osoba je ime objekta (instanca, pojavnost) - varijabla

            //Osoba osoba = new Osoba();

            Osoba osoba; // deklariran bez instance
            osoba = new Osoba(); // konstruiranje objekta - rađa se / kreira se, zauzima memoriju
            osoba.Ime = "Pero"; // objekt zivi i posjeduje vrijednost - postavljamo ih

            Console.WriteLine(osoba.Ime); // tu se vrijednosti konzumiraju


            // na kraju objekt (osoba) umire - unistava ga/cisti iz memorije
            // mi ne unistavamo objekt, to radi garbage collector
        }
    }
}
