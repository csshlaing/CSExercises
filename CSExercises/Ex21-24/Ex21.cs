using System;
namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int guess = 88;
            bool shouldcontinue = true;

            while(shouldcontinue)
            {
                Console.WriteLine("Please guess the correct number.");
                int number = Convert.ToInt16(Console.ReadLine());                

                if (guess == number)
                {
                    Console.WriteLine("Bingo!");
                    shouldcontinue = false;
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }
            }
            
        }
    }
}
