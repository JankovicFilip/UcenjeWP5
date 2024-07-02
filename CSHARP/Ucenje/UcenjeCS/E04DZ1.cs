using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E04DZ1
    {

        public static void Izvedi()
        {


            Console.Write("Please, enter your height (1.83): ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("Please, enter your weight (75): ");
            int weight = int.Parse(Console.ReadLine());

            double bmi = weight / (height * height);
            double newBmi = Math.Round(bmi, 2);

            if (newBmi <= 18.5)
            {
                Console.WriteLine("You are underweight.");
            }
            else if (newBmi <= 25)
            {
                Console.WriteLine("You are very healthy.");
            }
            else if (newBmi <= 30)
            {
                Console.WriteLine("You are slightly overweight!");
            }
            else if (newBmi <= 35)
            {
                Console.WriteLine("You are obese!");
            }
            else
            {
                Console.WriteLine("You are very unhealthy fat!");
            }

            Console.WriteLine(newBmi);


        }
    }
}
