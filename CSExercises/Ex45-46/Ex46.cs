using System;
namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            int[] array = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] occur = new int[10];            

            Console.WriteLine("Number \t Count");
            
            Random r = new Random(); int randomValue;
            for (int j = 0; j < 50; j++)
            {
                randomValue = r.Next(0, 9);

                switch(randomValue)
                {
                    case 0:
                        {
                            occur[0] = occur[0] + 1;
                            break;
                        }
                    case 1:
                        {
                            occur[1] = occur[1] + 1;
                            break;
                        }
                    case 2:
                        {
                            occur[2] = occur[2] + 1;
                            break;
                        }
                    case 3:
                        {
                            occur[3] = occur[3] + 1;
                            break;
                        }
                    case 4:
                        {
                            occur[4] = occur[4] + 1;
                            break;
                        }
                    case 5:
                        {
                            occur[5] = occur[5] + 1;
                            break;
                        }
                    case 6:
                        {
                            occur[6] = occur[6] + 1;
                            break;
                        }
                    case 7:
                        {
                            occur[7] = occur[7] + 1;
                            break;
                        }
                    case 8:
                        {
                            occur[8] = occur[8] + 1;
                            break;
                        }
                    case 9:
                        {
                            occur[9] = occur[9] + 1;
                            break;
                        }
                }               
            }
            for(int i=0; i<occur.Length;i++)
            {
                Console.WriteLine(array[i] + "\t" + "   " + occur[i]);
            }

            
         }

            
        
    }
}   
