using System;
namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int[] Sales = new int[3];
            int averageSale = 0;

            for(int i=0; i<3; i++)
            {
                Console.Write("Enter sales for month {0} :", i);
                Sales[i] = Convert.ToInt32(Console.ReadLine());                
                averageSale = averageSale + Sales[i];
            }
            //to find largest sales
            double largestSales = Sales[0];
            int maxMth = 0;
            for(int i=0; i<Sales.Length; i++)
            {
                if (Sales[i] > largestSales)
                {
                    largestSales = Sales[i];
                    maxMth = i;
                }
            }
            //to find smallest sales
            double smallestSales = Sales[0];
            int minMth = 0;
            for (int i = 0; i < Sales.Length; i++)
            {
                if (Sales[i] < smallestSales)
                {
                    smallestSales = Sales[i];
                    minMth = i;

                }
            }
            Console.WriteLine("Maximum Sales : {0} , {1}", maxMth, largestSales.ToString("C2"));
            Console.WriteLine("Minimum Sales : {0} , {1}", minMth, smallestSales.ToString("C2"));
            Console.WriteLine("Average Sales is {0}", averageSale.ToString("C2"));

        }
    }
}
