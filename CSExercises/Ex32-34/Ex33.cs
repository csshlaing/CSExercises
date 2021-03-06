using System;

namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] NumberList = new int[5];
            int i;

            //get user input & store in arry
            Console.WriteLine("Enter list of numbers.");
            for (i = 0; i < NumberList.Length; i++)
            {
                NumberList[i] = Convert.ToInt32(Console.ReadLine());                
            }
            //sort array data in descending order
            int green, red = 0;
            for (green=0; green <= NumberList.Length-1; green++)
            {
                for(red=green+1; red <= NumberList.Length-1; red++)
                {
                    if(NumberList[red] > NumberList[green])
                    {
                        int temp = NumberList[red];
                        NumberList[red] = NumberList[green];
                        NumberList[green] = temp;

                        //print out the progress of sorted data line by line
                        for (i = 0; i < NumberList.Length; i++)
                        {
                            Console.Write("{0}", NumberList[i]);
                            //Console.Write("{0}\t", NumberList[i]);
                        }
                        Console.WriteLine();
                    }
                }
            }      
        }
    }
}
