﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E04Z1
    {

        public static void Izvedi()
        {

            Console.Write("Molim unesite ocjenu od 1-5: ");
            int ocjena = int.Parse(Console.ReadLine());

            switch (ocjena)
            {
                case 1:
                    Console.WriteLine("Ne dovoljan");
                    break;
                case 2:
                    Console.WriteLine("Dovoljan");
                    break;
                case 3:
                    Console.WriteLine("Dobar!");
                    break;
                case 4:
                    Console.WriteLine("Vrlo dobar");
                    break;
                case 5:
                    Console.WriteLine("Odlican");
                    break;
                default:
                    Console.WriteLine("Niste unijeli dobru ocjenu: ");
                    break;

            }




        }
    }
}
