using System;
namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter an amount : "); 
            double input = Convert.ToDouble(Console.ReadLine()) * 100;
            //Console.WriteLine(input);

            while (input >= 100)
            {
                Console.WriteLine("100c");
                input = input - 100;
            }

            while (input >= 50)
            {
                Console.WriteLine("50c");
                input = input - 50;
            }

            while (input >= 20)
            {
                Console.WriteLine("20c");
                input = input - 20;
            }

            while (input >= 10)
            {
                Console.WriteLine("10c");
                input = input - 10;
            }

            while (input >= 5)
            {
                Console.WriteLine("5c");
                input = input - 5;
            }
        }
    }
}
