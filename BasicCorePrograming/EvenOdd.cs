using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograming
{
    internal class EvenOdd
    {
        public void CheckEvenOdd()
        {
            int num, rem;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            rem = num % 2;
            if(rem == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }
    }
}
