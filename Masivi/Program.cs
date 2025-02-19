using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masivi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[8];

            //1. input

            for (int i = 0; i < numbers.Length; i++) 
            {
                Console.WriteLine($"numbers[{i}]");
                numbers[i] = i; 
            }

            //2. 

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]},");
            }


            long Sum = 0;
            long oven = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if ( numbers[i] % 2 == 0)
                {
                Sum = Sum + numbers[i];       
                }
                else
                {
                    Console.WriteLine($"");
                }
                                        
            }
            Console.WriteLine($"{Sum}");
            Console.WriteLine($"avg {(double)Sum/ numbers.Length}");
            Console.WriteLine($" S of oven ");


        }
    }
}
