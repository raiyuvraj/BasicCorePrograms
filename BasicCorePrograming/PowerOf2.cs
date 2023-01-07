using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograming
{
    internal class PowerOf2
    {
        public void Power()
        {
            Console.WriteLine("Enter the power of 2");
            int Power = Convert.ToInt32(Console.ReadLine());
            
            if(Power >= 31)
            {
                Console.WriteLine("Program Overflow , please enter number below 31");
            }
            else
            {
                double pow_ab = Math.Pow(2, Power);
                Console.WriteLine("Result: " +pow_ab);
            }
        }
    }
}
