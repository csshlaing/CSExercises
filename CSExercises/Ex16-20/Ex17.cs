using System;

namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            {
                System.Console.WriteLine("Please enter your name ");
                string strName = System.Console.ReadLine();

                System.Console.WriteLine("Gender Please, M or F");
                string strGender = System.Console.ReadLine();

                System.Console.WriteLine("Please enter your age");
                int intAge = Convert.ToInt16(System.Console.ReadLine());

                if (strGender == "M" && intAge >=40)
                {
                    System.Console.WriteLine("Good Morning, Uncle {0}", strName);
                }
                else if(strGender == "M" && intAge <40)
                {
                    System.Console.WriteLine("Good Morning, Mr. {0}", strName);
                }
                else if (strGender == "F" && intAge >= 40)
                {
                    System.Console.WriteLine("Good Morning, Aunty {0}", strName);
                }
                else if (strGender == "F" && intAge < 40)
                {
                    System.Console.WriteLine("Good Morning, Ms. {0}", strName);
                }
            }
        }
    }
}