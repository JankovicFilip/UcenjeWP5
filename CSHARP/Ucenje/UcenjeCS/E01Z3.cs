using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01Z3
    {
        // osigurati da se upise grad aka trycatch
        // osigurati da se upise broj aka trycatch
        public static void Izvedi()
        {
            Console.Write("Unesi ime grada: ");
            var s = Console.ReadLine();

            Console.Write("Unesi broj stanovnika: ");
            int broj = int.Parse(Console.ReadLine());

            Console.WriteLine("U {0}" +"u " + "zivi {1}" +  " ljudi!", s, broj);



        }
    }
}
