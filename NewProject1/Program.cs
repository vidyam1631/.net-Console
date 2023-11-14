using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewClassLibrary1;

namespace NewProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pointer pointer1 = new Pointer();
            Console.WriteLine("Pointer x is {0} and y is {1}", pointer1.X, pointer1.Y);

            Pointer pointer2 = new Pointer(1,2);
            Console.WriteLine("Pointer x is {0} and y is {1}", pointer2.X, pointer2.Y);

            Pointer pointer3 = new Pointer(pointer1);
            Console.WriteLine("Pointer x is {0} and y is {1}", pointer3.X, pointer3.Y);

            Pointer pointer4 = new Pointer(6);
            Console.WriteLine("Pointer x is {0} and y is {1}", pointer4.X, pointer4.Y);

            Console.WriteLine("you have created {0} no of objects",Pointer.Counter);

            pointer1.display();
        }
    }
}
