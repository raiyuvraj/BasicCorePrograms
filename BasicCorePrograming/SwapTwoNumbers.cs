using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograming
{
    internal class SwapTwoNumbers
    {
        public void SwapNum()
        {
            Console.WriteLine("Enter two numbers to Swap");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine("Before Swap: " +first + ", " +second);
            int temp = first;
            first = second;
            second = temp;

            Console.WriteLine("After Swap: " +first +", " +second);
        }
    }
}
