using System;
namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a word!");
            //string input = Console.ReadLine();
            //string joinText = "";
//Question (b)

            string entry = Console.ReadLine();

            char[] c = new char[] { '!', '@', '#', '$', '%', '^', '&', '*', ' ' };
            string[] array = entry.Split(c);

            for (int i = 0; i < array.Length;i++ )
            {
                Console.WriteLine(array);
            }             
                   




//Question (a)
            //bool palindrome = false; int lastcount = 0;
            //int count = 0;

            ////Console.WriteLine(input[0]);
            //lastcount = input.Length - 1;
            ////Console.WriteLine(input[lastcount]);

            //for (int i = 0; i < input.Length / 2; i++)
            //{
            //    if (input[i] == input[lastcount - i])
            //    {
            //        palindrome = true;

            //    }
            //    else
            //    {
            //        palindrome = false;
            //        count++;
            //    }
            //}

            //if (palindrome && count == 0)
            //{
            //    Console.WriteLine("Palindrome!");
            //}
            //else
            //{
            //    Console.WriteLine("NOt Palindrome!");
            //}
                     
        }
    }
}
