using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your basic salary :");
            double salary = Convert.ToDouble(Console.ReadLine());

            double TotalIncome = salary + (salary * 0.1) + (salary * 0.03);
            Console.WriteLine("Your total income amount is {0}", TotalIncome.ToString("C2"));

            
        }
    }
}
