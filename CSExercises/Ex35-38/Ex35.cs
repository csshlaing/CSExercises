using System;
namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {         
            Console.Write("Please enter the phrase :");
            string input = Console.ReadLine();
            int Vcount = 0; 
            int countA = 0; int countE = 0; int countI = 0; int countO = 0; int countU = 0;

            for(int i=0; i<input.Length;i++)
            {
                if(Convert.ToString(input[i]) == "a")
                {
                    Vcount += 1;
                    countA += 1;

                }
                if (Convert.ToString(input[i]) == "e")
                {
                    Vcount += 1;
                    countE += 1;
                }
                if (Convert.ToString(input[i]) == "i")
                {
                    Vcount += 1;
                    countI += 1;
                }
                if (Convert.ToString(input[i]) == "o")
                {
                    Vcount += 1;
                    countO += 1;
                }
                if (Convert.ToString(input[i]) == "u")
                {
                    Vcount += 1;
                    countU += 1;
                }

            }
            Console.WriteLine("Total number of vowels : {0}", Vcount);
            Console.WriteLine("Number of a : {0}", countA);
            Console.WriteLine("Number of e : {0}", countE);
            Console.WriteLine("Number of i : {0}", countI);
            Console.WriteLine("Number of o : {0}", countO);
            Console.WriteLine("Number of u : {0}", countU);




            //Console.WriteLine(a.Length);
            //Console.WriteLine(vowels.GetLength(0));

            //string[] vowels = new string[] { "a", "e", "i", "o", "u" };

            //for (int i = 0; i < a.Length; i++)
            //{
            //    char c = Convert.ToChar(a.Substring(i, 1));
            //    //char v = Convert.ToChar(vowels.GetLength(j));

            //    for (int j = 0; j < vowels.GetLength(0) - 1; j++)
            //    {
            //        if (c == Convert.ToChar(vowels.GetLength(j)))
            //        {
            //            Vcount++;
            //        }

            //    }
            //}
            //Console.WriteLine("{0}", Vcount);

            //Console.WriteLine(a.Substring(0, 1));
            //Console.WriteLine(a.Substring(1, 1));
            //Console.WriteLine(a.Substring(2, 1));
            //Console.WriteLine(a.Substring(3, 1));
        }
    }
}
