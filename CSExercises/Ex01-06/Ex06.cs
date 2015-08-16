using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a double :");
            //int number = Console.ReadLine();

            //error correction : change user input value data type using convert.toint32, system methods.
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The squareroot of a number {0} is {1}", number, Math.Sqrt(number));
            
        }
    }
}
