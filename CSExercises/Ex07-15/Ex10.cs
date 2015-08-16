using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            int x1Value, y1Value, x2Value, y2Value;
            Console.WriteLine("Please enter x1 value");
            x1Value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter y1 value");
            y1Value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter x2 value");
            x2Value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter y2 value");
            y2Value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The values of two points x1={0}, y1={1}, x2={2}, y2={3}", x1Value,y1Value,x2Value,y2Value);

            double distance = Convert.ToDouble(((x2Value - x1Value) * (x2Value - x1Value)) + ((y2Value - y1Value) * (y2Value - y1Value)));
            Console.WriteLine("The distance between two points is {0}",  Math.Sqrt(distance));

        }
    }
}
