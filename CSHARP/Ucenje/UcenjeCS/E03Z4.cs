using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z4
    {

        public static void Izvedi()
        {

            Console.Write("Unesi grad: ");
            string grad = Console.ReadLine();

            if (grad == "Osijek")
            {
                Console.WriteLine("Slavonija!");
               
            }
            else if (grad == "Split")
            {
                Console.WriteLine("Dalmacija");
            }
            else if (grad == "Cakovec")
            {
                Console.WriteLine("Medimurje");
            }
            else if (grad == "Pula")
            {
                Console.WriteLine("Istra");
            }
            else
            {
                Console.WriteLine("Ne znam koja je to regija!");
            }

            
            switch(grad)
            {
                case "Osijek":
                    Console.WriteLine("Slavonija");
                    break;
                case "Split":
                    Console.WriteLine("Dalmacija");
                    break;
                case "Cakovec":
                    Console.WriteLine("Medimurje");
                    break;
                case "Pula":
                    Console.WriteLine("Istra");
                    break;
                default:
                    Console.WriteLine("Ne znam koja je to regija!");
                    break;


            }

        }
    }
}
