using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograming
{
    internal class LargestAmongThree
    {
        public void LargestNumber() 
        {
            Console.WriteLine("Enter Three numbers:");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            if(first>second&& second>third)
            {
                Console.WriteLine(first+ " is the largest number among all.");
            }
            else if(second>third)
            {
                Console.WriteLine(second + " is the largest among all.");

            }
            else
            {
                Console.WriteLine(third + " is the largest among all.");
            }
        }

    }
}
