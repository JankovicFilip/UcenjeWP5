using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UcenjeCS.E18KonzolnaAplikacija.Model;

namespace UcenjeCS.E18KonzolnaAplikacija
{
    public class ObradaSmjer
    {
        public List<Smjer> Smjerovi { get; set; }
        public ObradaSmjer()
        {

            Smjerovi = new List<Smjer>();
            if (Pomocno.DEV)
            {
                UcitajTestnePodatke();
            }
        

        }

        private void UcitajTestnePodatke()
        {
            Smjerovi.Add(new() { Sifra = 1, Naziv = "Web programiranje" });
            Smjerovi.Add(new() { Sifra = 2, Naziv = "AAAA" });
            Smjerovi.Add(new() { Sifra = 3, Naziv = "BBBB" });
            Smjerovi.Add(new() { Sifra = 4, Naziv = "CCCC" });
            Smjerovi.Add(new() { Sifra = 5, Naziv = "DDDD" });
        }

        public void PrikaziIzbornik() 
        {
            Console.WriteLine("Rad s smjerovima");
            Console.WriteLine("1 Prikazi sve smjerove");
            Console.WriteLine("2 Dodaj novi smjer");
            Console.WriteLine("3 Promijeni");
            Console.WriteLine("4 Obrisi");
            Console.WriteLine("5 Vrati na glavni izbornik");
            OdabirOpcijeIzbornika();




        }

        private void OdabirOpcijeIzbornika()
        {
            switch(E11Metode.UcitajCijeliBroj("Odaberi stavku izbornika",1, 5))
            {
                case 1:
                    PrikaziSveSmjerove();
                    PrikaziIzbornik();
                    break;
                case 2:
                    DodajNoviSmjer();
                    PrikaziIzbornik();
                    break;
                case 3:
                    PromijeniSmjer();
                    PrikaziIzbornik();
                    break;
                case 4:
                    ObrisiSmjer();
                    PrikaziIzbornik();
                    break;
                case 5:
                    break;
            } 
        }

        private void ObrisiSmjer()
        {
            PrikaziSveSmjerove();
            Smjerovi.RemoveAt(
                E11Metode.UcitajCijeliBroj("Odaberi redni broj smjera za brisanje",1,Smjerovi.Count)-1
                );

        }

        private void PromijeniSmjer()
        {
            PrikaziSveSmjerove();
            var s = Smjerovi[
                E11Metode.UcitajCijeliBroj("Odaberi redni broj smjera", 1, Smjerovi.Count) - 1
                ];
            s.Sifra = E11Metode.UcitajCijeliBroj("Unesi novu vrijednost sifre (" + s.Sifra + ")", 1, int.MaxValue);
            s.Naziv = Pomocno.UcitajString("Unesi novi naziv smjera (" + s.Naziv + ")");
        }

        private void DodajNoviSmjer()
        {
            Smjerovi.Add(new()
            {
                Sifra = E11Metode.UcitajCijeliBroj("Unesi sifru smjera",1,int.MaxValue),
                Naziv = Pomocno.UcitajString("Unesi naziv smjera")
            });
        }

        public void PrikaziSveSmjerove()
        {
            if (Smjerovi.Count == 0) // ovo je povezano sa linijom 14 iz Izbornik klase, obavijesti te da su smjerovi prazni, u ovom slucaju ako je DEV false
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
            foreach(var s in Smjerovi)
            {
                Console.WriteLine(++rb + ". " + s.Naziv);
            }
        }
    }
}
