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
            int broj;
            int suma = 0;
            while (true)
            {
                Console.Write("Upisi cijeli broj: ");

                try
                {

                    broj = int.Parse(Console.ReadLine());
                    if (broj <= 0 || broj > 1000)
                    {
                        Console.WriteLine("Broj mora biti izmedu 1 i 1000!");
                        continue;
                    }
                    

                    
                    break;


                }
                catch
                {
                    Console.WriteLine("Niste unijeli broj!");
                }
            }
            for (int i = broj; i % 2 == 0;)
            {
                
                suma += i;
            }
            Console.WriteLine(suma);
            

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
