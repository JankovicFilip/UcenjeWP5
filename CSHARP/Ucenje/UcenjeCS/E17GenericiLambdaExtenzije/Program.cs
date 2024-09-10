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

            smjerovi.Add(new Smjer() { Sifra = 11, Naziv = "WP5" });

            smjerovi.Add(new() { Sifra = 7, Naziv = "RR" });
            smjerovi.Add(new() { Sifra = 9, Naziv = "PHP" });

            Console.WriteLine(smjerovi[1].Sifra);

            // Obrada<string> p = new Obrada<string>(); // string ne nasljeduje entitet

            Obrada<Smjer> o1 = new Obrada<Smjer>();
            o1.ObjektObrade = new Smjer() { Sifra = 1, Naziv = "WP5" };

            Obrada<Polaznik> o2 = new Obrada<Polaznik>();
            o2.ObjektObrade = new Polaznik() { Sifra = 2, Ime = "Pero", Prezime = "Peric" };

            o1.Obradi();
            o2.Obradi();

            List<DateTime> datum = new List<DateTime>();
            datum.Add(new DateTime(1993, 11, 11));
            datum.Add(DateTime.Now);

            Console.WriteLine(datum[0]);


            // lambda izrazi
            Console.WriteLine(KlasicnaMetoda(2, 3));

            var Zbroj = (int x, int y) => x + y;

            Console.WriteLine(Zbroj(2, 3));

            var Algoritam = (int x, int y) =>
            {
                var t = x + 1;
                return t - y;
            };
            Console.WriteLine(Algoritam(2, 3));

            
            var parni = (int x) => x % 2 == 0; 
            
            Console.WriteLine(parni(4));

            // extenzije

            var s = "Osijek";
            Console.WriteLine(s.LastOrDefault());

            Console.WriteLine(gradovi.LastOrDefault());

            Console.WriteLine(smjerovi.LastOrDefault());

            smjerovi[0].OdradiPosao();
            o2.ObjektObrade.OdradiPosao(); //polaznici
            o1.PrikazRadaSSuceljem();
            o2.ObjektObrade.PrikazRadaSSuceljem();
            smjerovi[0].PrikazRadaSSuceljem();

            smjerovi.Sort();
            Console.WriteLine(smjerovi.FirstOrDefault()?.Sifra); // icomparable extenzija

            // bez koristenja implementacije sucelja IComparable
            smjerovi.Sort((s1,s2) => s1.Naziv.CompareTo(s2.Naziv));

            Console.WriteLine(smjerovi.FirstOrDefault().Naziv);

            o1.ListaZaObradu = smjerovi;
            o1.IspisStavaka(TuMeOdradi);
            o1.IspisStavaka(s =>
            {
                Console.WriteLine("I bez poziva metode " + s.Naziv);
            });
        }

        public void TuMeOdradi(Smjer s)
        {
            Console.WriteLine("Obradujem u programu smjer s pozivom metode " + s.Naziv);
        }



        public int KlasicnaMetoda(int x, int y)
        {
            return x + y;
        }
    }
}
