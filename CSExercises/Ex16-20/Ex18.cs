using System;
namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your mark :");
            int intMark = Convert.ToInt16(Console.ReadLine());
            
            if (intMark >= 0 || intMark <= 100)
            {
                if (intMark >= 80 && intMark <= 100)
                {
                    Console.WriteLine("Your Score is {0} marks which is A grade.", intMark);

                }
                else if (intMark >= 60 && intMark <= 79)
                {
                    Console.WriteLine("Your Score is {0} marks which is B grade.", intMark);
                }
                else if (intMark >= 40 && intMark <= 59)
                {
                    Console.WriteLine("Your Score is {0} marks which is C grade.", intMark);
                }
                else if (intMark >= 0 && intMark <= 40)
                {
                    Console.WriteLine("Your Score is {0} marks which is F grade.", intMark);
                }
                else{
                    Console.WriteLine("Something Wrong, ERROR !");
                }
            }
        }
    }
}