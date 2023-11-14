using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a no");
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine("You entered {0}", num);
           

            int year;
            bool validYear = int.TryParse("2018a", out year);
            if(validYear)
            {
                Console.WriteLine("converted 2018 string to int {0}", year);
            }
            else
            {
                Console.WriteLine("unable to convert");
            }
            Console.ReadLine();
        }
    }
}
