using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E15KlasaObjekt.Edunova
{
    internal class Smjer
    {

        public int? Sifra { get; set; }
        public string? Naziv { get; set; }
        public decimal? Cijena { get; set; }
        public int BrojSati { get; set; }
        public DateTime? IzvodiSeOd { get; set; }
        public bool? Vaucer { get; set; }

        // u vecini drugi prog jezika ide ovako

        private int Broj;

        public void SetBroj(int broj) { this.Broj = broj; }

        public int GetBroj() { return this.Broj; }

    }
}
