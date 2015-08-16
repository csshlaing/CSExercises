using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a double :");
            double number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The square of a number {0} is {1}", number, number * number );
        }
    }
}
