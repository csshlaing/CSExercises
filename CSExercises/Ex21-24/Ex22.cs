using System;
namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number A :");
            int A = Convert.ToInt32(Console.ReadLine());
            int temp = A;
            Console.Write("Enter number B :");
            int B = Convert.ToInt32(Console.ReadLine());
            

            int largeNumber = 0;
            bool equal = false;

            while(!equal)
            {
                if(A > B)
                {
                    largeNumber = A - B;
                    A = largeNumber;
                    if (A == B)
                    {
                        equal = true;
                    }
                }
                else
                {
                    largeNumber = B - A;
                    B = largeNumber;
                    if (A == B)
                    {
                        equal = true;
                    }
                }
                
            }
            Console.WriteLine("HCF {0}", largeNumber);
            int LCM = (temp * B) / largeNumber;          
            Console.WriteLine("LCM : {0}", LCM);


            
        }
    }
}
