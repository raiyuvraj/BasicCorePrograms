using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograming
{
    internal class VowelConsonanat
    {
        public void Alphabet()
        {
            Console.WriteLine("Enter the alphabet: ");
            char ch = Convert.ToChar(Console.ReadLine());

            switch(ch)
            {
                case 'a':
                    Console.WriteLine(ch+ " is Vowel");
                    break;
                case 'e':
                    Console.WriteLine(ch + " is Vowel");
                    break;
                case 'i':
                    Console.WriteLine(ch + " is Vowel");
                    break;
                case 'o':
                    Console.WriteLine(ch + " is Vowel");
                    break;
                case 'u':
                    Console.WriteLine(ch + " is Vowel");
                    break;
                default:
                    Console.WriteLine(ch + " is Consonanat");
                    break;

            }
        }
    }
}
