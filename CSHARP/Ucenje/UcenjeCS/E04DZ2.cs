using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E04DZ2
    {

        public static void Izvedi()
        {


            Console.Write("Please, enter your height (1.83): ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("Please, enter your weight (75): ");
            int weight = int.Parse(Console.ReadLine());

            double bmi = weight / (height * height);
            double newBmi = Math.Round(bmi, 2);

            switch (newBmi)
            {
                case <= 18.5:
                    Console.WriteLine("You are underweight.");
                    break;
                case <= 25:
                    Console.WriteLine("You are very healthy.");
                    break;
                case <= 30:
                    Console.WriteLine("You are slightly overweight!");
                    break;
                case <=35:
                    Console.WriteLine("You are obese!");
                    break;
                default:
                    Console.WriteLine("You are very unhealthy fat!");
                    break;
            }

            Console.WriteLine(newBmi);


        }
    }
}
