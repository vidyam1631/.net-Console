using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_Inheritance;

namespace Console_Inheritance
{
    internal class Program
    {

        static void Main(string[] args)
        {
            First first = new First();
            first.GetFirstValue();

            Second second = new Second();
            second.GetSecondValue();

            Third third = new Third();
            third.GetThirdValue();

            First first1 = new First(10);
            first1.GetFirstValue();

            Second second1 = new Second(100);
            second1.GetSecondValue();

            Second second2 = new Second(20,200);//f is 100
            second2.GetSecondValue();

            Third third1 = new Third(10,20,30);
            third1.GetThirdValue();


        }
    }
}
