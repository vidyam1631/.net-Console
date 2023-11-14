using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_StringComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "hello";
            string str2 = string.Copy(str1);
            string str3 = "world";

            Console.WriteLine("Using==operator:");
            Console.WriteLine(str1==str2);
            Console.WriteLine(str1==str3);

            Console.WriteLine("Using Equals method:");
            Console.WriteLine(str1.Equals(str2));
            Console.WriteLine(str1.Equals(str3));

            object obj1 = str1;
            object obj2 = str2;


            Console.WriteLine("Using == operator with objects:");
            Console.WriteLine(obj1 == obj2);

            Console.WriteLine("using Equals method with objects:");
            Console.WriteLine(obj1.Equals(obj2));
            Console.ReadLine();


        }
    }
}
