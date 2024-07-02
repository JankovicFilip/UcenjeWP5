using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E04DZ4
    {


        public static void Izvedi()
        {

            Console.Write("Molim unesite godinu: ");
            int godina = int.Parse(Console.ReadLine());

            bool isLeapYear = godina switch
            {
                _ when godina % 400 == 0 => true,
                _ when godina % 100 == 0 => false,
                _ when godina % 4 == 0 => true,
                _ => false
            };

            string message = isLeapYear ? "Ovo je prijestupna godina!" : "Ovo nije prijestupna godina!";
            Console.WriteLine(message);
        }
    }
}
