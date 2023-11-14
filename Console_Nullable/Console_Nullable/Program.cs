using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? i = 10;//nullable type
            int j;
            //j=i//gives an error
            j=(int)i;
            Console.WriteLine("j="+j);
            i = j * 2;
            i = null;
            //j = (int)i; this will give runtime error cuz null cannot be converted to int which it realize while running
            int k;
            k = i ?? 10;//if i  is null then 10 will be assigned to k else value of i
            Console.WriteLine("value of k is {0} ", k);
            i = 100;
            k = i ?? 10;
            Console.WriteLine("value of k is {0} ", k);

            string str = "as";
            object obj = str;
            if(str is int)
            {
                Console.WriteLine("str is int");

            }
            else
            {
                Console.WriteLine("str is not int");
            }

            object[] MyObj= new object[3];
            MyObj[0] = 12;
            MyObj[1] = "abd";
            MyObj[2] = true;
            

            //value of MyObj[0] is an int(12), and you are attempting to cast it using the as operator.Since the cast is not valid,str2 will be assigned to MyObj[1] as it is string
            string str2 = MyObj[0] as string;
            Console.WriteLine("str2 = {0} ",str2);
            string str3 = MyObj[1] as string;
            Console.WriteLine("str3 = {0} ", str3);
            string str4 = MyObj[2] as string;
            Console.WriteLine("str3 = {0} ", str4);


            string s_num = "12";
            //int num = (int)s_num;
            //Console.WriteLine("num = {0} ", num);

            var num1 = 10;
            var str1 = "abc";
            dynamic d_num1;
            d_num1 = 100;
            d_num1 = "abs";
            Console.WriteLine("num1:{0}. str1={1}, d_num={2}",num1,str1,d_num1);

        }
    }
}
