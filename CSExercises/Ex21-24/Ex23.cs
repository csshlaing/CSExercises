using System;
namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {            
            int count = 0;
            int guess = 0;
            Random r = new Random();
            int secretNumber = r.Next(0, 10);

            do
            {
                Console.Write("Think of a number : ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess == secretNumber)
                {
                    count++;
                    Console.WriteLine("Congratulation, {0} attemps you did !", count);
                    switch(count)
                    {
                        case 2:
                            Console.WriteLine("You are a Wizard!");
                            break;
                        case 3:
                            Console.WriteLine("You are a good guess!");
                            break;
                        default:
                            Console.WriteLine("You are lousy!");
                            break;
                    }

                }
                else
                {
                    count++;
                    Console.WriteLine("Incorrect, please try again");
                }
            } while (guess != secretNumber); 
        }
    }            
}
