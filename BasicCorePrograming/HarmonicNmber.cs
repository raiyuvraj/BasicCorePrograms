using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograming
{
    internal class HarmonicNmber
    {
        public void Harmonic()
        {
            Console.WriteLine("Find the Harmonic Numbers");
            Console.WriteLine("Enter Harmonic Value which we have to find");
            int HarmonicNum = Convert.ToInt32(Console.ReadLine());
            double result = 1.0;
            Console.WriteLine("1/1");

            for (int i = 2; i <= HarmonicNum; i++)
            {
                Console.WriteLine($"+1/{i}");
                result += 1 / (double)i;

            }
            Console.WriteLine("nth Harmonic value = " + result);
        }
    }
}
