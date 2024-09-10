﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E17GenericiLambdaExtenzije
{
    internal class Obrada<T> where T : Entitet
    {
        public T? ObjektObrade { get; set; }

        public void Obradi()
        {
            Console.WriteLine(ObjektObrade?.Sifra);


        }


    }
}
