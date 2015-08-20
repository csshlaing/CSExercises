using System;
namespace CSExercises
{
    public class Ex43
    {
        public static void Main(string[] args)
        {
            //convert interger 1-100 as a hex in a string variable.
            //for (int j = 0; j <= 100; j++)
            //{
            //    string hexValue = j.ToString("X");
            //    Console.WriteLine(hexValue);
            //}

            // Convert the hex string back to the number
            //int decAgain = int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);
            

            Console.WriteLine("Enter a number :");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Hex(i));
                
        }
        
        public static string Hex(int i)
        {
            string result = "";
            result = Convert.ToString(i % 16);
            i = i / 16;

            result = SwitchABC(result) + result;

            return result;
        }

        public static string SwitchABC(string temp)
        {
            switch (temp)
            {
                case "10":
                    temp = "A";
                    break;
                case "11":
                    temp = "B";
                    break;
                case "12":
                    temp = "C";
                    break;
                case "13":
                    temp = "D";
                    break;
                case "14":
                    temp = "E";
                    break;
                case "15":
                    temp = "F";
                    break;
                default:
                    temp = Convert.ToString(temp);
                    break;
            }
            return temp;
        }

    }
}
