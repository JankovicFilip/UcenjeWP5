using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01Z1
    {
        public static void Izvedi()
        {
            int broj1;
            int broj2;
            while (true)
            {




                try
                {
                    Console.Write("Upisi prvi cijeli broj: ");
                    broj1 = int.Parse(Console.ReadLine());
                    
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli cijeli broj!");
                }




            }

            while (true)
            {




                try
                {
                    Console.Write("Unesi drugi cijeli broj: ");
                    broj2 = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli cijeli broj!");
                }




            }





            Console.WriteLine(broj1+broj2);




        }






    }
}
