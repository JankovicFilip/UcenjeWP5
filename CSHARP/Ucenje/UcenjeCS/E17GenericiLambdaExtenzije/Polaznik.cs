﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E17GenericiLambdaExtenzije
{
    internal class Polaznik : Entitet,ISucelje
    {

        public string? Ime { get; set; }
        public string? Prezime { get; set; }

        public void Posao()
        {

            Console.WriteLine("Odradujem posao na polazniku!");
        }
    }
}