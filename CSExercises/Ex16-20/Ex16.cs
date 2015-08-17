namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter your name ");
            string strName = System.Console.ReadLine();

            System.Console.WriteLine("Gender Please, M or F");
            string strGender = System.Console.ReadLine();

            if (strGender == "M")
            {
                System.Console.WriteLine("Good Morning, Mr. {0}", strName);
            }
            else if(strGender == "F")
            {
                System.Console.WriteLine("Good Morning, Ms. {0}", strName);
            }
        }
    }
}