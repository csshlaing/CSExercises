using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex20
    {
        static int read()
        {
            return Convert.ToInt16(Console.ReadLine());           
        }

        public static double GrandTotal(int qtyTV, int qtyDVD, int qtyMP3)
        {
            if ((qtyTV * 900 + qtyDVD * 500) < 5000)
            {
                double totalAmt = (qtyTV * 900) + (qtyDVD * 500) + (qtyMP3 * 700);
                return totalAmt;
            }
            else
            {
                if ((qtyTV * 900 + qtyDVD * 500) < 10000)
                {
                    double totalAmt = ((qtyTV * 900 + qtyDVD * 500) * 0.9);
                    return (totalAmt + (qtyMP3 * 700));
                }
                else
                {
                    double totalAmt = ((qtyTV * 900 + qtyDVD * 500) * 0.85);
                    return (totalAmt + (qtyMP3 * 700));
                }
            }
        }        
        public static void Main(string[] args)
        {

            int qtyTV, qtyDVD, qtyMP3;
            Console.WriteLine("Enter quantity for TV :");
            qtyTV = read();
            Console.WriteLine("Enter quantity for DVD :"); 
            qtyDVD = read();
            Console.WriteLine("Enter quantity for MP3 :");
            qtyMP3 = read();
            Console.WriteLine("The Grand Total Price for your order is {0}", GrandTotal(qtyTV, qtyDVD, qtyMP3));

        }
    }
}