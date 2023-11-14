using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using utility;

namespace useUtililty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int result=AddClass.Add(10, 20);
            int addresult = AddClass.Add(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]));
            Console.WriteLine("addresult :"+addresult);

            Console.WriteLine(args[2]);

            //int result2 = MulClass.Mul(10, 20);
            int mulresult= MulClass.Mul(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]));
            Console.WriteLine("mulresult :"+mulresult);

            //int result3 = SubClass.Sub(10, 20);
            //Console.WriteLine(result3);
        }
    }
}
