using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the distance travelled :");
            double dblValue = Math.Round(Convert.ToDouble(Console.ReadLine()));
            double dblValueMeter = dblValue * 10;

            if (dblValueMeter > 100)
            {
                double dblTotalCost = Convert.ToDouble((2.4 + (85 * 0.04) + ((dblValueMeter - 90) * 0.05)));
                Console.WriteLine("Total Cost {0}", dblTotalCost.ToString("C2"));

            }
            else if (dblValueMeter < 100)
            {
                double dblTotalCost = Convert.ToDouble(2.4 + (85 * 0.04));

                Console.WriteLine("Total Cost {0}", dblTotalCost.ToString("C2"));
            }
        }
    }
}