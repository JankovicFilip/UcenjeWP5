using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E15KlasaObjekt
{
    // klasa je opisnik objekta
    internal class Osoba
    {

        // klasa sadrzi svojstva iliti property
        public int? Sifra { get; set; }
        public string? Ime { get; set; } // ? upitnik oznacava da ime moze biti null
        public string? Prezime { get; set; }

        public Mjesto? Mjesto { get; set; }




        // klasa sadrzi metode
        public string ImePrezime()
        {
            return Ime + " " + Prezime;
        }




    }
}
