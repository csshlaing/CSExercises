using System;
namespace CSExercises
{
    public class Ex44
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a word : "); string s = Console.ReadLine();
            Console.WriteLine("Find ? : "); char c1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Replace : "); char c2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("The new word : {0}", Substitute(s, c1, c2));

        }
        public static string Substitute(string s, char c1, char c2)
        {
            return s = s.Replace(c1, c2);            
        }
    }
}
