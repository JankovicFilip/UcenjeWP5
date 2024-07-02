using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E06ForPetlja
    {

        public static void Izvedi()
        {


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Osijek");
            }

            // unutar petlje varijabla mijenja vrijednost
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1);
            }

            // koristenje vrijednosti u petlji

            int suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                suma += i;

            }
            Console.WriteLine(suma);
            Console.WriteLine("**********");


            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("**********");

            int brojOd = 12;
            int brojDo = 2;

            for (int i = brojOd; i > brojDo; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("**********");
            int[] niz = { 2, 3, 4, 5, 6, 7, 8, 9 };
            // ispisati sve parne vrijednosti niza

            for (int i = 0; i < niz.Length; i++)
            {
                if (niz[i] % 2 == 0)
                {
                    Console.WriteLine(niz[i]);
                }
            }

            int[,] tablica =
            {
                {1,2,3 },
                {4,5,6},
                {7,8,9}
            };

            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    Console.Write(tablica[i, j] + " ");
                }
                Console.WriteLine();
            }


            // tablica mnozenja
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write((i + 1) * (j + 1) + " ");
                }
                Console.WriteLine();
            }


            // petlja se moze preskociti (nastaviti) i nasilno prekinuti
            int ukupno = 0;
            for (int i = 0; i < 10; i++)
            {   
                if(i == 1 || i == 3)
                {
                    continue;
                }

                if (++ukupno > 5)
                {
                    break;
                }





                Console.WriteLine(i);
                
            }



            Console.WriteLine("**********");


            for (int i = 0;i < 10; i++)
            {
                for(int j = 0;j < 10; j++)
                {
                    break;
                }
                // ovdje zavrsava nakon break
            }


            // beskonacna petlja

            // losa
            for (int i = 0; i > -1; i++)
            {
                break;
            }



            // ispravna beskonacna petlja for
            int broj = 0;
            for(; ; )
            {
                Console.Write("Unesi broj izmedu 10 i 20: ");
                broj = int.Parse(Console.ReadLine());
                if (broj >= 10 && broj <= 20)
                {
                    break;
                }
                Console.WriteLine("Neispravan unos!");
            }
            Console.WriteLine("Unijeli ste " + broj);


            // nizovi + petlje

            // string tip podatka je zapravo niz znakova

            string ime1 = "Ana";
            char[] ime2 = { 'A', 'n', 'a' };

            for(int i = 0; i < ime2.Length; i++)
            {
                Console.Write(ime2[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < ime1.Length; i++)
            {
                Console.Write(ime1[i]);

            }





        }
    }
}
