using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E17GenericiLambdaExtenzije
{
    internal class Program
    {

        public Program()
        {
            // glavni problem rada sa genericima: ograniceni sa inicijalnim brojem elemenata
            // rjesenje je: koristiti genericke klase

            // klasa list je parametizirana tipom podatka int i u nju mogu ici samo brojevi
            List<int> integeri = new List<int>();

            integeri.Add(1);
            integeri.Add(21);
            Console.WriteLine(integeri[0]);

            List<string> gradovi = new List<string>();

            gradovi.Add("Osijek");
            gradovi.Add("Valpovo");
            Console.WriteLine(gradovi[1]);


            List<Smjer> smjerovi = new List<Smjer>();

            smjerovi.Add(new Smjer() { Sifra = 1, Naziv = "WP5" });

            smjerovi.Add(new() { Sifra = 7, Naziv = "RR" });

            Console.WriteLine(smjerovi[1].Sifra);

            // Obrada<string> p = new Obrada<string>(); // string ne nasljeduje entitet

            Obrada<Smjer> o1 = new Obrada<Smjer>();
            o1.ObjektObrade = new Smjer() { Sifra = 1, Naziv = "WP5" };

            Obrada<Polaznik> o2 = new Obrada<Polaznik>();
            o2.ObjektObrade = new Polaznik() { Sifra = 2, Ime = "Pero", Prezime = "Peric" };

            o1.Obradi();
            o2.Obradi();

            List<DateTime> datum = new List<DateTime>();
            datum.Add(new DateTime (1993, 11, 11 ));
            datum.Add(DateTime.Now);

            Console.WriteLine(datum[0]);




        }
    }
}
