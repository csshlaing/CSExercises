using System;
namespace CSExercises
{
    public class Ex39
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number.");
            long input = Convert.ToInt64(Console.ReadLine());

            long answer = Factorial(input);

            Console.WriteLine(answer);

        }

        public static long Factorial(long n)
        {

            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * i;

            }

            return result;
        }


//***** for reference //calculation done in main function & how to separate new function for factorial calculation
        //public static void Main(string[] args)
        //{
        //    Console.Write("Enter a number.");
        //    long input = Convert.ToInt64(Console.ReadLine());

        //    long result = 1;
        //    for (int i = 1; i <= input; i++)
        //    {
        //        result = result * i;

        //    }

        //    Console.WriteLine(result);

        //}
    }
}
