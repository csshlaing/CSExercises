using System;
namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int input = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i=1; i < input; i++)
            {
                if(input % i == 0)
                {
                    sum += i;
                }
            }
            //Console.WriteLine(sum);
            if(sum == input)
            {
                Console.WriteLine("Perfect Number!");
            }
            else
            {
                Console.WriteLine("Not Perfect Number!");
            }
            
        }
    }
}
