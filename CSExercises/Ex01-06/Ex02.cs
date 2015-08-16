using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter an integer :");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The square of an integer {0} is {1} " , number, number * number);
        }
    }
}