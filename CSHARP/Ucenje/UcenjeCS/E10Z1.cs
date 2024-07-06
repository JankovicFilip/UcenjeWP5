using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E10Z1
    {
        public static void Izvedi()
        {
            int[] broj = new int[0];
            int suma = 0;
            while (true)
            {
                Console.Write("Upisi cijeli broj: ");

                try
                {

                    int broj1 = int.Parse(Console.ReadLine());
                    if (broj1 <= 0 || broj1 > 1000)
                    {
                        Console.WriteLine("Broj mora biti izmedu 1 i 1000!");
                        continue;
                    }
                    broj = new int[broj1];

                    
                    break;


                }
                catch
                {
                    Console.WriteLine("Niste unijeli broj!");
                }
            }
            foreach (int broj1 in broj)
            {
                suma += broj1;
            }
            Console.WriteLine("Sum: " + suma);
            foreach (int broj1 in broj)
            {
                Console.WriteLine(broj1);
            }
            

            int[] brojevi = new int[10];
            int sum = 0;
            for (int i = 0; i < brojevi.Length; i++)
            {
                Console.WriteLine("Unesi {0}. broj: ",i+1);
                brojevi[i] = int.Parse(Console.ReadLine());
                sum += brojevi[i];
            }
            Console.WriteLine(sum);
            foreach(var b in brojevi)
            {
                Console.WriteLine(b);
            }



        }


    }
}
