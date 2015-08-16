using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("#Temperature Conversion from Centigrade to Fahrenheit");
            Console.WriteLine("Please enter Temperature in Centigrade");

            double Ctemperature = Convert.ToDouble(Console.ReadLine());
            double Ftemperature = (1.8 * Ctemperature) + 32;

            Console.WriteLine("Temperature in Fahrenheit Scale is {0}", Ftemperature);

        }
    }
}
