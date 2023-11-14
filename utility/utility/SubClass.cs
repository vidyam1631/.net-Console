using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utility
{
    public class SubClass
    {
        public static int Sub(int n1, int n2)
        {
            int sub;
            sub = n1 - n2;
            Console.WriteLine("the multiplicatin is:" + sub);

            return sub;
        }
    }
}
