using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljedivanjePolimorfizam
{
    internal class Program
    {

        // konstruktor -- posebna vrsta metode koja se poziva prilikom kreiranja instance klase - objekta
        // kljucna rijec je "new"
        // konstruktor se naziva kao i klasa


        public Program()
        {
            Console.WriteLine("Hello from constructor!");

            var s = new Smjer();
            s.Sifra = 2;
            s.Naziv = "WP";
            Console.WriteLine(s.Sifra);
            Console.WriteLine(s.Naziv);

            Console.WriteLine(s.GetHashCode());

            var s1 = new Smjer() { Sifra = 2, Naziv = "WP"};
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s.Equals(s1));

            // string je nepromijenjiv - imutable
            var a = "A";
            Console.WriteLine(a.GetHashCode());
            

            a = a + "B";
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(a);
            StringBuilder sb = new StringBuilder();
            sb.Append("A");
            Console.WriteLine(sb.GetHashCode());
            sb.Append("B");
            Console.WriteLine(sb.GetHashCode());
            Console.WriteLine(sb);

            // u radu sa stringom se treba raditi sa StringBuilder

            Console.WriteLine(s);

            var g = new Grupa() { Sifra = 1, DatumPocetka = DateTime.Now };
            Console.WriteLine(g);

            var polaznik = new Polaznik();
            polaznik.Ime = "Pero";
            polaznik.Sifra = 1;

            var predavac = new Predavac() { Sifra = 1, Ime = "Marko" };

            Console.WriteLine("{0} - {1}", polaznik,predavac);

        }


        // moze se raditi oveload konstruktora

        public Program(string s)
        {
            Console.WriteLine("Hello from constructor " + s);
        }



    }
}
