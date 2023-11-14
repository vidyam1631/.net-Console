using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MethodParams(1, "Vidya", 18);
            MethodParams(2, "Sakshi");
            MethodParams(3);
            MethodParams(4,e_age:25,e_name:"riya");
            MethodParams( e_age: 27, e_id: 5, e_name: "piya");
        }
        public static void MethodParams(int e_id, string e_name="abc",int e_age = 18)
        {
            Console.WriteLine("Employee Details :");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Id: {0}\nName: {1}\nAge: {2}",e_id,e_name,e_age);

        }
    }
}
