using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_RefOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10, k = 100, l;
            Console.WriteLine("The value of k before change is " + k);
            CheckValues(ref k, i, out l);
            Console.WriteLine("the value of k after change is " + k);
            Console.WriteLine("the value of i after change is " + i);
            Console.WriteLine("the value of l after change is "+l);


            joinParams(1, 2);
            joinParams("hello", "world");

            //for loop for debugging
            for(int m= 0; m < 10; m++)
            {
               Console.WriteLine(m);
            }
        }static void CheckValues(ref int num1,int num2,out int num3)
        {
            num1++;
            num2++;
            num3 = 300;
        }

        static void swapFun(ref int num1, int num2)
        {
           
            num1 = num1+num2;
            num2 = num1 - num2;
            num1= num1-num2;
        }

        //method overloading
        static void joinParams(int num1,int num2)
        {
            Console.WriteLine((num1 + num2));
        }
        static void joinParams(string str1, string str2) 
        {
            Console.WriteLine((str1 + str2));
        }
    }
}
