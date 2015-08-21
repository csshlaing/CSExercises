using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter the distance KM :");
            double dblDistance = Convert.ToDouble(Console.ReadLine());

            double dblTotalFare = Math.Round((2.40 + dblDistance * 0.4), 1);
            Console.WriteLine("The total fare is {0:0.00}", dblTotalFare);
        }
    }
}
