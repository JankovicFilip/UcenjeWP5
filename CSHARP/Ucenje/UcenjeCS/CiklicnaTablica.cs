using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class CiklicnaTablica
    {

        public static void Izvedi()
        {
            Console.Write("Broj redova: ");
            int red = int.Parse(Console.ReadLine());
            Console.Write("Broj stupaca: ");
            int stupac = int.Parse(Console.ReadLine());

            int[,] ciklicnaTablica = new int [red, stupac];

            int umnozak =1, minstupac = 0, maxstupac = stupac - 1, minred = 0, maxred= red - 1;

            while(umnozak <= red * stupac)
            {
                if(umnozak > red * stupac)
                {
                    break;
                }
                for(int i = maxstupac; i >= minstupac; i--)
                {
                    ciklicnaTablica[maxred, i] = umnozak;
                    umnozak++;
                }
                
                if (umnozak > red*stupac)
                {
                    break;
                }
                for(int i = maxred - 1; i >= minred; i--)
                {
                    ciklicnaTablica[i,minstupac] = umnozak;
                    umnozak++;
                }
                
                if (umnozak > red * stupac)
                {
                    break;
                }
                for(int i = minstupac +1; i <= maxstupac; i++)
                {
                    ciklicnaTablica[minred,i] = umnozak;
                    umnozak++;
                }
                
                if (umnozak > red * stupac)
                {
                    break;
                }
                for (int i = minred + 1; i < maxred; i++)
                {
                    ciklicnaTablica[i,maxstupac] = umnozak;
                    umnozak++;
                }
                maxred--;
                minstupac++;
                minred++;
                maxstupac--;








               


            }
            for (int i = 0; i < red; i++)
            {
                for (int j = 0; j < stupac; j++)
                {
                    Console.Write(ciklicnaTablica[i, j]);
                }
                Console.WriteLine();
            }





        }
    }
}
