using System;
namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("X\tY");
            Console.WriteLine("------------");

            for (int xValue = -5; xValue < 5; xValue++)
            {
                double yValue = ((2 * (xValue * xValue)) - (4 * xValue) + 3);
                Console.WriteLine("{0:0.0##}\t{1:0#.0##}", xValue, yValue);
            }

            Console.WriteLine("Y    Star");
            Console.WriteLine("-------------------------------------------------------------------------------");

            
            for (int xValue1 = -5; xValue1 < 5; xValue1++)
            {
                double yValue1 = ((2 * (xValue1 * xValue1)) - (4 * xValue1) + 3);
                string star = "";
                for (int j = 1; j <= yValue1; j++)
                {                    
                    star = star + "*";                    
                }
                ////Console.WriteLine("{0:0#.0##} {1}", yValue1, star);
                Console.WriteLine("{0:0#.0##} {1}", yValue1,star);
            }
            Console.ReadLine();
        }
    }
    }


