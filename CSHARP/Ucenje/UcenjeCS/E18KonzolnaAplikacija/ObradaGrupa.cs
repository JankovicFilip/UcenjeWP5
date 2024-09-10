using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E18KonzolnaAplikacija.Model;

namespace UcenjeCS.E18KonzolnaAplikacija
{
    public class ObradaGrupa
    {
        public List<Grupa> Grupe { get; set; }
        public Izbornik Izbornik { get; set; }
        public ObradaGrupa(Izbornik Izbornik)
        {
            this.Izbornik = Izbornik;
            Grupe = new List<Grupa>();
            if(Pomocno.DEV)
            {
                UcitajTestnePodatke();
            }


        }

        

        private void UcitajTestnePodatke()
        {
            Grupe.Add(new() { Sifra = 1, Naziv = "WP5", Smjer = Izbornik.ObradaSmjer.Smjerovi[0] });
            Grupe.Add(new() { Sifra = 1, Naziv = "WP4", Smjer = Izbornik.ObradaSmjer.Smjerovi[1] });
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Rad s grupama");
            Console.WriteLine("1 Prikazi sve grupe");
            Console.WriteLine("2 Dodaj novi grupu");
            Console.WriteLine("3 Promijeni");
            Console.WriteLine("4 Obrisi");
            Console.WriteLine("5 Vrati na glavni izbornik");
            OdabirOpcijeIzbornika();




        }

        private void OdabirOpcijeIzbornika()
        {
            switch(E11Metode.UcitajCijeliBroj("Odaberi stavku izbornika", 1, 5))
            {
                case 1:
                    PrikaziSveGrupe();
                    PrikaziIzbornik();
                    break;
                case 2:
                    DodajNovuGrupu();
                    PrikaziIzbornik();
                    break;
                case 5:
                    break;
                
            }
        }

        private void DodajNovuGrupu()
        {
            var g = new Grupa();
            g.Sifra = E11Metode.UcitajCijeliBroj("Unesi sifru grupe",1,int.MaxValue);
            g.Naziv = Pomocno.UcitajString("Unesi naziv grupe");
            var ios = Izbornik.ObradaSmjer;
            ios.PrikaziSveSmjerove();
            g.Smjer = ios.Smjerovi[
                E11Metode.UcitajCijeliBroj("Odaberite smjer za ovu grupu",1,ios.Smjerovi.Count) -1
                ];
            Grupe.Add( g );

        }

        private void PrikaziSveGrupe()
        {
            if (Grupe.Count == 0) // ovo je povezano sa linijom 14 iz Izbornik klase, obavijesti te da su smjerovi prazni, u ovom slucaju ako je DEV false
            {
                var staraB = Console.BackgroundColor;
                var staraF = Console.ForegroundColor;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Nema smjerova u bazi");
                Console.BackgroundColor = staraB;
                Console.ForegroundColor = staraF;

                return;
            }
            var rb = 0;
            foreach (var e in Grupe)
            {
                Console.WriteLine(++rb + ". " + e.Naziv + "(" + e.Smjer?.Naziv + ")" );
            }
        }
    }
}
