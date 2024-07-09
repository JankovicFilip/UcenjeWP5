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
            Tip2("Edunova");
            Tip2("Osijek", 7);

            Tip3(); // metoda koja vraca vrijednost moze biti pozvana kao i void i odraditi ce se ali njezin rezultat "ode uu vjetar"
            Console.WriteLine(Tip3()); // u ovom slucaju se tip3 mora pozvati ovako
            // Console.WriteLine(Tip1()); ovo ne radi tako
            for (int i = 0; i < 10; i++)

            {
                Console.WriteLine(SlucajnaRijec());
            }
            

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

        // method overloading sa linijom 57
        private static void Tip2()
        {
            Tip2(2);
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
        // metoda moze imati isti naziv sve dok prima razlicite parametere

        private static void Tip2(string ime) // gore imamo tip2 koji prima  int, a ovaj tip2 prima string i moze se pozvati, ali nije dobra praksa
        {

            Console.WriteLine("Preopterecena s stringom vrijednoscu: {0}", ime);
        }
        
        private static void Tip2(string ime, int b)
        {
            Console.WriteLine("Metoda primila {0} i {1} ", ime, b);
        }
        // metoda vraca vrijednost
        static int Tip3()
        {
            Console.WriteLine("U metodi Tip3 sam: ");
            return int.MaxValue;
        }

        static int SlucajniBroj()
        {
            return new Random().Next();


        }
        static string SlucajnaRijec()
        {
            char[] niz = new char[8];

            var r = new Random();
            for(int i = 0; i < niz.Length; i++)
            {
                niz[i] = (char)r.Next(65,90);
            }




            return string.Join("",niz);


        }


    }
}
