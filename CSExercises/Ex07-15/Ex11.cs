using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter the distance :");
            double dblDistance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The total fare is {0}", 2.40 + (dblDistance * 0.4));
        }
    }
}
