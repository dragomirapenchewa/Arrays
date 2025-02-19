using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //da se wuwedat n na br imena w klawiqturata 
            //da se wuwede ime za tursene nis 
            //programata da pr da li e w masiwa
            //ako e w masiwa da se otpechati na koe mqsto e indeksa mu
            //ako go nqma w masiwa da se otpechati this is not foundstringstring

            Console.WriteLine("Wuwedi kolko imena iskash we: ");
            int n = int.Parse(Console.ReadLine());
            string[] names = new string[n];
            bool Isnotfound = false;

            for (int i = 0; i < names.Length - 1; i++)
            {
                Console.WriteLine($"[{i}] = ");
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("---------");
            for (int i = 0; i < names.Length - 1; i++)
            {
                Console.WriteLine($"imena[{i}] = {names[i]} ");
            }

            Console.WriteLine("Wuwedi tursenmo ime:");
            string searchname = Console.ReadLine();

            for (int i = 0; names[i].Length > 0; i++)
            {
                if (searchname == names[i])
                {
                    Console.WriteLine($"{searchname} e na [{i}] poziciq");
                   Isnotfound = true;
                    break;
                }
            
            }
            if (Isnotfound != true) 
            {
                Console.WriteLine($"{names} is not finded!");
            }
            //kolko puti se srerstha chisloto

            int count = 0;
            for (int i = 0; count < n; i++) 
            {
                count++;
            }
            
            Console.WriteLine($"chisloto e namereno tolkowa puti {count} ");

            //стринговете се сравнияват c Campeare
            //masiv s [] i to se mesti s arrys
            //i e indeks
        }
    }
}
