using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograming
{
    internal class QuoandRem
    {
        public void QuoRem()
        {
            int quotient, remainder;
            Console.WriteLine("Enter the Dividend");
            int dividend = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Divisor");
            int divisor = int.Parse(Console.ReadLine());

            quotient = Math.DivRem(dividend, divisor, out remainder);
            Console.WriteLine("Quotient is: " + quotient+ "and Reaminder is: " +remainder);
        }
    }
}
