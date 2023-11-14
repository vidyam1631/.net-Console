using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Polymorphism
{
    public partial class Employee1
    {
        partial void AddEmp()
        {
            Console.WriteLine("indside addemp method");
        }
        partial void EditEmp();
    }
}
