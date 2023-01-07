using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograming
{
    internal class Factors
    {
        public void PrimeFactor()
        {
            Console.WriteLine("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = 1;

            for(int i=1; i<=num; i++)
            {
                result= result * i;
            }
            Console.WriteLine("Factorial of " + num + "is" + result);
        }
    }
}
