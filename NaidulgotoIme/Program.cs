using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaidulgotoIme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nai dulgoto ime 
            //kolko imena she wuwejdash 
            //wkarwame gi
            //

            Console.WriteLine("Kolko imena she wuwedesh");
            int n = int.Parse(Console.ReadLine());
            string[] names = new string[n];


            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();

            }

            names[0] = "Tonq Berlezirewa";

            names[names.Length - 1] = "Dragomira Penchewa";
//sreden element 
            int avgindex =
            names.Length / 2;
            names[avgindex] = "Georgi Genow";


            for (int i = names.Length - 1; i >= 0; i--) 
            { 
                Console.WriteLine($"{names[i]},");
                
            }

            //da se wuwedat imena
            //da prowerqwa da li masiva e simetrtichen
            

        }
    }
}
