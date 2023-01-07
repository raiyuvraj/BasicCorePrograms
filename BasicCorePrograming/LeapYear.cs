using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograming
{
    internal class LeapYear
    {
        public void CheckLeapYear()
        {
            Console.WriteLine("Enter Year");
            int year = Convert.ToInt32(Console.ReadLine());

            if(year % 4 == 0)
            {
                Console.WriteLine("It is a Leap Year");
            }
            else
            {
                Console.WriteLine("Not a Leap Year");
            }
        }
    }
}
