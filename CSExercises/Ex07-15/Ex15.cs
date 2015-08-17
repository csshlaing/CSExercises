using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter three digits");
            double dblValue = Convert.ToDouble(Console.ReadLine());

            if(dblValue > 100 && dblValue < 999)
            {

                double dblV1, dblV2, dblV3;

                dblV1 = Math.Floor(dblValue / 100);
                Console.WriteLine("{0}", dblV1);    //print just for checking

                dblV2 = Math.Floor((dblValue - (dblV1 * 100)) / 10);
                Console.WriteLine("{0}", dblV2);    //print just for checking

                dblV3 = Math.Floor(dblValue % 10);
                Console.WriteLine("{0}", dblV3);    //print just for checking

                double dblArmstrongNumber = ((dblV1 * dblV1 * dblV1) + (dblV2 * dblV2 * dblV2) + (dblV3 * dblV3 * dblV3));
                if (dblArmstrongNumber == dblValue)
                {
                    Console.WriteLine("Your Number, {0} is Armstrong Number.", dblValue);
                }
                else
                {
                    Console.WriteLine("Not Armstrong Number! Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Please enter between 100 to 999!");
            }                       
        }
    }
} 