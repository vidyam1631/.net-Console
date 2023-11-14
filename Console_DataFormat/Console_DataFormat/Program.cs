using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_DataFormat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10, sqr = num * num, cube=num*num*num;
            int pocketMoney = 1000, percent = 89, balanceAmt=12000;
            String name = "vidya";

            

            Console.WriteLine("The square of "+num+" is "+sqr);
            Console.WriteLine("The square of {0} is {1} and cube of {0} is {2}" , num, sqr,cube);

            //specify spaces to print which is defined using -10 i.e 10 spaces are left form 0oth element
            Console.WriteLine("sum of {0,-10} is {1,-10} and cube is {2,-10}", num, sqr, cube);

            Console.WriteLine("____________________________________");
            Console.WriteLine(" {0,-10}{1,-10}{2,-10}","num","sqr","cube");
            Console.WriteLine("____________________________________");
            Console.WriteLine(" {0,-10}{1,-10}{2,-10}", num, sqr, cube);

            Console.WriteLine("{0} gets {1:C} as pocket money and he got {2:P} as percentage and his bank balance is {3:N}", name, pocketMoney, percent/100,balanceAmt);


            CultureInfo customCulture = new CultureInfo("en-US");
            customCulture.NumberFormat.CurrencySymbol = "₹";
            string formattedPocketMoney = pocketMoney.ToString("C", customCulture);
            Console.WriteLine("{0} gets {1} as pocket money and he got {2:P} marks", name, formattedPocketMoney, percent);
            Console.ReadLine();


        }
    }
}
