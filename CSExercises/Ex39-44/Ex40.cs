using System;
using System.Data.SqlClient;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
//******result out based on user input******
            //Console.WriteLine("Enter a number .");
            //int input = Convert.ToInt32(Console.ReadLine());

            //double answer = SQT(input);
            //Console.WriteLine("The Square root of {0} is ", answer);

            for(int i=1; i <=25; i++)
            {
                Console.WriteLine("The Square root of {0} is {1}", i, SQT(i));
            }
        }

        public static double SQT(int y)
        {
            return Math.Sqrt(y);
            
        }
    }
}
