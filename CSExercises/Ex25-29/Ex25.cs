using System;
namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            //*****(b) decrement counter as i--
            Console.Write("Enter a number :  "); int input = Convert.ToInt32(Console.ReadLine());
            int result = 1; string list = "";
            for (int i = input; i > 0; i--)
            {
                list = list + i + "x";
                result *= i;

            }
            //Console.WriteLine("Factorial of {0}! = {1}", input, list.Substring(0,list.Length-1));   ***format factorial form
            Console.WriteLine("(b) {0}! = {1} = {2} ", input, list.Substring(0, list.Length - 1), result);
            


            //*****(a) increment counter as i++
            
            int resultA = 1; string listA = "";
            for (int i = 1; i <= input ; i++)
            {
                listA = listA + i + "x";
                resultA *= i;

            }
            //Console.WriteLine("Factorial of {0}! = {1}", input, list.Substring(0,list.Length-1));   ***format factorial form
            Console.WriteLine("(a) {0}! = {1} = {2} ", input, listA.Substring(0, listA.Length - 1), resultA);

            Console.ReadLine();
        }
    }
}
