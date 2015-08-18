using System;
namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Console.Write("Input a number :"); int input = Convert.ToInt32(Console.ReadLine());

            Random r = new Random();
            int guess = r.Next(1, input);

            if(guess == Math.Sqrt(input))
            {
                Console.WriteLine("Input {0}, same with square of Guess {1}", input, guess * guess);
            }
            else
            {
                guess = (guess + (input / guess)) / 2;
                Console.WriteLine("Formula Calculation {0:0.00000}", guess);
            }
             
        }
    }
}
