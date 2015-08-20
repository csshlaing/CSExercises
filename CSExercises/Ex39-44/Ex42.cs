using System;
namespace CSExercises
{
    public class Ex42
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a phrase .");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter a word .");
            string s2 = Console.ReadLine();

            Console.WriteLine(FindWord(s1, s2));
        }
        public static int FindWord(string s1, string s2)
        {
            int occur = 0; int position = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s2.Length; j++)
                {
                  if(s1[i] == s2[j])
                  {
                      position = i;
                      occur++;
                  }
                }
            }
            if (occur > 0)
            {
                return position - s2.Length+1;

            }
            else
            {
                return -1;
            }
            
            
        }
    }
}
