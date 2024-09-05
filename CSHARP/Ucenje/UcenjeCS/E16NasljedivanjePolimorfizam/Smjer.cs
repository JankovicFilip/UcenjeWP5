using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljedivanjePolimorfizam
{
    internal class Smjer : Entitet // klasa smjer nasljeduje javna i zasticena svojstva klase entitet, u ovom slucaju sifra
    {
        public string? Naziv { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
