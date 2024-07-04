using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E07WhilePetlja
    {


        public static void Izvedi()
        {
            // u for petlju se ne more uci
            int brojDo = 0; // ako je nula, unio korisnik ili ja napisao, nece uci u for petlju
            for (int i = 0; i < brojDo; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("************************");

            while(true)
            {
                for(int i = 0; i < 10; i++)
                {
                    Console.Write(new Random().Next() + " ");
                }
                Console.WriteLine();
                Thread.Sleep(500);
                break; // ako nema break raditi ce beskonacno skroz dok je true
            }

            Console.WriteLine("************************");
            brojDo = 10;
            while(brojDo--  > 0)
            {
                Console.WriteLine(brojDo);
            }

            int j = 2;
             while(brojDo < 10 && j ==2)
            {
                Console.WriteLine(brojDo++);
            }
            Console.WriteLine("************************");
            brojDo = 0;
            while(brojDo < 10)
            {
                if(++brojDo == 2)
                {
                    continue;
                }
                Console.WriteLine(brojDo);
                //brojDo++;
            }

            Console.WriteLine("************************");
            brojDo = 1;
            
            while (brojDo <= 10)
            {
                j = 1;
                while (j <= 10)
                {
                    Console.Write(brojDo * j++ + "\t");
                }
                Console.WriteLine();
                brojDo++;
            }

            Console.WriteLine("************************");

            // hoce li se uvijek uci u while petlju
            // NECE

            brojDo = 0;
            while(brojDo > 0)
            {

            Console.WriteLine(brojDo); // ovo se nece ispisati jer nije usao u petlju, nije zadovoljen uvjet
            }




        }
    }
}
