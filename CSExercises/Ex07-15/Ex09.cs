using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter x value : ");
            int xValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x={0}\ty=?", xValue);

            double yValue = ((2 * (xValue * xValue)) - ((4 * xValue) + 3));
            Console.WriteLine("The value of y is {0}", yValue);

        }
    }
}
