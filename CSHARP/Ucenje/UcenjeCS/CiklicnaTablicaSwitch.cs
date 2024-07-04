using System;

namespace UcenjeCS
{
    internal class CiklicnaTablicaSwitch
    {
        public static void Izvedi()
        {
            Console.Write("Broj redova: ");
            int red = int.Parse(Console.ReadLine());
            Console.Write("Broj stupaca: ");
            int stupac = int.Parse(Console.ReadLine());

            Console.Write("Početak tablice: dolje desno prema lijevo (dl), dolje desno prema gore (dg), gore desno prema lijevo (gd), gore lijeva u smjeru kazaljke na satu (gl): ");
            string pocetak = Console.ReadLine();

            int[,] ciklicnaTablica = new int[red, stupac];

            int umnozak = 1, minstupac = 0, maxstupac = stupac - 1, minred = 0, maxred = red - 1;

            
            switch (pocetak)
            {
                case "dl":
                    while (umnozak <= red * stupac)
                    {
                        if (umnozak > red * stupac)
                        {
                            break;
                        }
                        for (int i = maxstupac; i >= minstupac; i--)
                        {
                            ciklicnaTablica[maxred, i] = umnozak++;
                        }
                        if (umnozak > red * stupac)
                        {
                            break;
                        }
                        for (int i = maxred - 1; i >= minred; i--)
                        {
                            ciklicnaTablica[i, minstupac] = umnozak++;
                        }

                        if (umnozak > red * stupac)
                        {
                            break;
                        }
                        for (int i = minstupac + 1; i <= maxstupac; i++)
                        {
                            ciklicnaTablica[minred, i] = umnozak++;
                        }

                        if (umnozak > red * stupac)
                        {
                            break;
                        }
                        for (int i = minred + 1; i < maxred; i++)
                        {
                            ciklicnaTablica[i, maxstupac] = umnozak++;
                        }

                        maxred--;
                        minstupac++;
                        minred++;
                        maxstupac--;
                    }
                    break;

                case "dg":
                    while (umnozak <= red * stupac)
                    {
                        if (umnozak > red * stupac)
                        {
                            break;
                        }
                        for (int i = maxred; i >= minred; i--)
                        {
                            ciklicnaTablica[i, maxstupac] = umnozak++;
                        }

                        if (umnozak > red * stupac)
                        {
                            break;
                        }
                        for (int i = maxstupac - 1; i >= minstupac; i--)
                        {
                            ciklicnaTablica[minred, i] = umnozak++;
                        }

                        if (umnozak > red * stupac)
                        {
                            break;
                        }
                        for (int i = minred + 1; i <= maxred; i++)
                        {
                            ciklicnaTablica[i, minstupac] = umnozak++;
                        }

                        if (umnozak > red * stupac)
                        {
                            break;
                        }
                        for (int i = minstupac + 1; i <= maxstupac - 1; i++)
                        {
                            ciklicnaTablica[maxred, i] = umnozak++;
                        }

                        minred++;
                        maxstupac--;
                        maxred--;
                        minstupac++;
                    }
                    break;

                case "gd":
                    while (umnozak <= red * stupac)
                    {
                        if (umnozak > red * stupac)
                        {
                            break;
                        }
                        for (int i = maxstupac; i >= minstupac; i--)
                        {
                            ciklicnaTablica[minred, i] = umnozak++;
                        }

                        minred++;

                        if (umnozak > red * stupac)
                        {
                            break;
                        }
                        for (int i = minred; i <= maxred; i++)
                        {
                            ciklicnaTablica[i, minstupac] = umnozak++;
                        }

                        minstupac++;

                        if (umnozak > red * stupac)
                        {
                            break;
                        }
                        for (int i = minstupac; i <= maxstupac; i++)
                        {
                            ciklicnaTablica[maxred, i] = umnozak++;
                        }

                        maxred--;

                        if (umnozak > red * stupac)
                        {
                            break;
                        }
                        for (int i = maxred; i >= minred; i--)
                        {
                            ciklicnaTablica[i, maxstupac] = umnozak++;
                        }

                        maxstupac--;
                    }
                    break;

                case "gl":
                    while (umnozak <= red * stupac)
                    {
                        for (int i = minstupac; i <= maxstupac && umnozak <= red * stupac; i++)
                        {
                            ciklicnaTablica[minred, i] = umnozak++;
                        }
                        minred++;

                        for (int i = minred; i <= maxred && umnozak <= red * stupac; i++)
                        {
                            ciklicnaTablica[i, maxstupac] = umnozak++;
                        }
                        maxstupac--;

                        for (int i = maxstupac; i >= minstupac && umnozak <= red * stupac; i--)
                        {
                            ciklicnaTablica[maxred, i] = umnozak++;
                        }
                        maxred--;

                        for (int i = maxred; i >= minred && umnozak <= red * stupac; i--)
                        {
                            ciklicnaTablica[i, minstupac] = umnozak++;
                        }
                        minstupac++;
                    }
                    break;

                default:
                    Console.WriteLine("Nepoznat smjer. Pokušajte ponovno.");
                    return;
            }

          
            

            
            for (int i = 0; i < red; i++)
            {
                for (int j = 0; j < stupac; j++)
                {
                    Console.Write(ciklicnaTablica[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
