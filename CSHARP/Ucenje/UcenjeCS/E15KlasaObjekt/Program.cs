using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E15KlasaObjekt.Edunova;

namespace UcenjeCS.E15KlasaObjekt
{
    internal class Program
    {

        public static void Izvedi()
        {


            Console.WriteLine("Hello oop!");

            // objekt je pojavnost klase iliti instanca klase

            // Osoba je ime klase --- opisnik objekta
            // osoba je ime objekta (instanca, pojavnost) - varijabla

            //Osoba osoba = new Osoba();

            Osoba osoba; // deklariran bez instance
            osoba = new Osoba(); // konstruiranje objekta - rađa se / kreira se, zauzima memoriju
            osoba.Ime = "Pero"; // objekt zivi i posjeduje vrijednost - postavljamo ih

            osoba.Prezime = "Perija";
            Console.WriteLine(osoba.Ime); // tu se vrijednosti konzumiraju

            Console.WriteLine(osoba.ImePrezime()); // metoda imePrezime nije staticna jer nju zovem na objektu (Osoba)


            // na kraju objekt (osoba) umire - unistava ga/cisti iz memorije
            // mi ne unistavamo objekt, to radi garbage collector

            // drugi nacini kreiranja objekta

            Osoba ravnatelj = new Osoba
            {
                Sifra = 1,
                Ime = "Marko",
                Prezime = "Marec"
            };

            var direktor = new Osoba { Ime = "Edo"};


            Osoba profesor = new() { Prezime = "Reh" , Ime = "Jakob"};

            Console.WriteLine(profesor.Ime?.ToUpper()); // null pointer exception ako na Ime ne stavim ?


            var O = new Osoba()
            {
                Ime = "Marija",
                Mjesto = new() { Naziv = "Osijek", PostanskiBroj = "31000"}
            };


            Console.WriteLine(O.Mjesto?.Naziv?.ToUpper());



            // dugi nacin


            Zupanija obz = new Zupanija();
            obz.Naziv = "Osječko-baranjska županija";
            
            Mjesto os = new Mjesto();
            os.Naziv = "Osijek";

            os.Zupanija = obz;

            Osoba ja = new Osoba();
            ja.Ime = "Filip";
            ja.Mjesto = os;

            Console.WriteLine(ja.Mjesto?.Zupanija?.Naziv?.ToUpper());

            CultureInfo ci = CultureInfo.InvariantCulture;
            //ci.CompareInfo.Version

            //objekti iz edunova klasa

            var smjer = new Smjer() { Sifra = E11Metode.UcitajCijeliBroj("Unesi sifru: ", 1,10000) , Naziv = "Web Programiranje" };

            var grupa = new Grupa() { Naziv = "WP5", Smjer = smjer };

            Console.WriteLine(grupa.Smjer.Sifra);
        }
        
    }
}
