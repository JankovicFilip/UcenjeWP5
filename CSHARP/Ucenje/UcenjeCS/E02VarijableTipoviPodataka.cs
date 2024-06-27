using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E02VarijableTipoviPodataka
    {

        public static void Izvedi()
        {
            //deklaracija varijable
            int i;

            //dodijeljivanje vrijednosti
            i = 7;

            //koristenje variable
            Console.WriteLine(i);

            Console.Write("Unesi broj: ");
            int broj = int.Parse(Console.ReadLine());
            Console.WriteLine(broj + 1);


            // decimalni brojevi = float
            Console.Write("Unesi decimalni broj (, je oznaka za decimalni broj): ");
            Console.WriteLine(float.Parse(Console.ReadLine()) + 1);

            bool uvjet = false;

            Console.WriteLine(uvjet);


            // operatori za rad sa varijablama
            // =, +, -, *, /
            // == operator usporedivanja, tipa bool
            // != razlicito tipa bool
            int j = 3;
            Console.WriteLine(j == 3);
            Console.WriteLine(j != 6);

            // increment i decrement
            i = 0;
            i = i + 1;
            i += 1;
            i++; // prvo koristi pa uveca
            ++i; // prvo uveca pa koristi

            i = 1;
            Console.WriteLine(i++); //1
            Console.WriteLine(i);  //2
            Console.WriteLine(++i); //3
            Console.WriteLine(i); //3

            // dekrement ista stvar samo -
            i--;
            --i;

            int x = 0, y = 1;
            x = ++x - y; // x = 0, y = 1
            y = x-- + y; // x = -1, y = 1
            Console.WriteLine(x + y); // 0

            // operator modulo %

            Console.WriteLine("9%2 {0}", 9 % 2);
            Console.WriteLine("8%2 {0}", 8 % 2);
            // ctrl k d formatira kod

            x = 5; 
            y = 2;

            // int / int daje int, mora se raditi cast (float)
            Console.WriteLine(x/(float)y); // (float) cast tip podatka u float
        }


    }
}
