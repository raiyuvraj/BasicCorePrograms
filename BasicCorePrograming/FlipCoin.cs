using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograming
{
    public class FlipCoin
    {
            double HeadCount = 0;
            double TailCount = 0;
            double PercentageOfHead = 0;
            double PercentageOfTail = 0;
       
        public void CheckHailTail()
        {
            Console.WriteLine("Enter number of times you want to flip the coin");
            double NumOfCount = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<NumOfCount; i++)
            {
                Random ranobj = new Random();
                double randomnumber = ranobj.NextDouble();

                if(randomnumber  < 0.5)
                {
                    Console.WriteLine("Tail");
                    TailCount++;
                }
                else
                {
                    Console.WriteLine("Head");
                    HeadCount++;
                }
            }
            Console.WriteLine("Total Tail Count: " + TailCount);
            Console.WriteLine("Total Head Count: " + HeadCount);

            Console.WriteLine("Percentage of Head and Tail");
            PercentageOfHead = HeadCount / NumOfCount * 100;
            Console.WriteLine("Head Percentage: " +PercentageOfHead);
            PercentageOfTail = TailCount / NumOfCount * 100;
            Console.WriteLine("Tail Percentage: " +PercentageOfTail);
        }
    }

}
