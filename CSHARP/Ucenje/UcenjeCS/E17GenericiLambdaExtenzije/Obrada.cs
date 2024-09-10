using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E17GenericiLambdaExtenzije
{
    internal class Obrada<T>: ISucelje where T : Entitet
    {
        public T? ObjektObrade { get; set; }
        public List<T>? ListaZaObradu {  get; set; }

        public void Obradi()
        {
            Console.WriteLine(ObjektObrade?.Sifra);


        }




        public void Posao()
        {
            Console.WriteLine("Odradujem posao u obradi!");
        }


        public void IspisStavaka (Action<T> akcija)
        {
            ListaZaObradu?.ForEach(e => akcija(e));
        }

       
    }
}
