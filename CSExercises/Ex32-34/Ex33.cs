using System;

namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] NumberList = new int[5];
            int i;

            Console.WriteLine("Enter list of numbers.");
            for (i = 0; i < NumberList.Length; i++)
            {
                NumberList[i] = Convert.ToInt32(Console.ReadLine());
 
                //int SmallestTemp = NumberList[0];

                //if (NumberList[i] < SmallestTemp)
                //{
                //    SmallestTemp = NumberList[i];
                //    NumberList[i - 1] = SmallestTemp;
                //}  
            }

            Console.Write(NumberList[i] + "\t");
            string exit = Console.ReadLine();

        }
    }
}
