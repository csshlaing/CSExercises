using System;
namespace CSExercises
{
    public class Ex41
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a phrase .");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter a word .");
            string s2 = Console.ReadLine();

            Console.WriteLine(InString(s1, s2));

        }
        public static bool InString(string s1, string s2)
        {
            int occur = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                for(int j=0; j<s2.Length; j++)
                {
                    if(s1[i] == s2[j])
                    {
                        occur++;
                    }
                }
            }
            if(occur<1)
            {
                return false;
            }
            else
            {
                return true;
            }
                
        }
    }
}
