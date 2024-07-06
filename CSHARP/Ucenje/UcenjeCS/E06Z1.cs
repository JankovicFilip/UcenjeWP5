using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E06Z1
    {
        public static void Izvedi()
        {
            int broj1 = 12;
            int broj2 = 58;

            if (broj1 >= broj2)
            {
                for (int i = broj1; i > broj2; i++)
                {
                    Console.WriteLine(i);
                }

            }
            else
            {
                for (int i = broj2; i > broj1; i--)
                {
                    Console.WriteLine(i);
                }
            }

            int brojOd = broj1 < broj2 ? broj1 : broj2;
            int brojDo = broj1 > broj2 ? broj1 : broj2;

            for (int i = brojOd; i < brojDo; i++)
            {
                Console.WriteLine(i);
            }





        }




    }
}
