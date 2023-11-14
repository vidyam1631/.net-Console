using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Console_StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] c = { 'a', 'b', 'c' };
            string str1=new string(c);
            string str2="add";
            string str3 = string.Concat(str1, str2);
            Console.WriteLine("str3= "+str3);
            string str4 = "Ganesh";
            string sub = str4.Substring(0,5);
            Console.WriteLine("SUB is {0}", sub);
            string replaced=str4.Replace("esh","apti");
            Console.WriteLine("replaced is {0}",replaced);

            string text = "apple,banana,mango";
            string[] fruits = text.Split(',');
            string text1 = "Hello, World!";
            bool containsHello = text1.Contains("Hello");
            bool startsWithHello=text1.StartsWith("Hello");
            bool endsWithWorld = text1.EndsWith("World!");

            //string builder
            StringBuilder sb=new StringBuilder();
            sb.Append("hello");
            sb.Append("world");
            Console.WriteLine("sb is {0}", sb);



        }
    }
}
