using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E04DZ3
    {


        public static void Izvedi()
        {

            Console.Write("Molim unesite godinu: ");
            int godina = int.Parse(Console.ReadLine());


            if(godina % 4 == 0)
            {
                if (godina % 100 == 0)
                {
                    if (godina % 400 == 0)
                    {
                        Console.WriteLine("Ovo je prijestupna godina!");
                    }
                    else
                    {
                        Console.WriteLine("Ovo nije prijestupna godina");
                    }
                
                }
                else
                {
                    Console.WriteLine("Ovo je prijestupna godina!");
                }
            }
            else
            {
                Console.WriteLine("Ovo nije prijestupna godina!");
            }


        }
    }
}
