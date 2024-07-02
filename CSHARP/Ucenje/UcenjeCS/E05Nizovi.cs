using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E05Nizovi
    {

        public static void Izvedi()
        {
            // arrays ili nizovi ili polja

            int[] temperature = new int[12];

            // nizovi pocinju sa indexom 0
            // prvi element niza je na 0
            temperature[0] = -2; // sijecanj
            temperature[1] = 0;
            temperature[2] = 5;

            temperature[11] = -3; // prosinac

            Console.WriteLine(temperature.Length); // vraca ukupan broj elemenata

            // ovako se zadnji element postavlja, u ovom slucaju 12
            temperature[temperature.Length - 1] = 0;

            Console.WriteLine(temperature[1]);

            // temperature[12] = 1;  baci error jer je out of bounds
            Console.WriteLine(temperature);

            // ispisate sve elemente
            Console.WriteLine(string.Join(",",temperature));

            // skraceniji nacin
            int[] niz = { 2, 3, 4, 5, 6, 7, 56, 9, 10, };

            Console.WriteLine(niz[6]);

            string[] gradovi = { "Osijek", "Donji Miholjac", "Valpovo" };

            Console.WriteLine(gradovi[gradovi.Length-1]); // ispisuje zasnje u nizu

            // ovo gore su sve jednodimenzionalni nizovi

            int[,] tablica = {
            {1,2,3 },
            {4,5,6 },
            {7,8,9 }            
            };
            Console.WriteLine(tablica[1, 2]);
            Console.WriteLine(tablica[2, 2]);

            // 3 dimenzije niz
            int[,,] kocka = { };

            // tesaarect - 4 dimenzije
            int[,,,] tesaarect = { };

            // nizovi mogu imati i razlicite tipove podataka
            object[] objekti = {"ovo",3,2.6,true };



        }


    }
}
