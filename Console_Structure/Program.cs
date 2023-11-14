using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Console_Structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(1,"Vidya", 32000);
            emp.display();
            Employee emp1 = new Employee(2, "Vidya");
            emp1.display();
            Employee emp2 = new Employee();
            emp2.Id = 3;
            emp2.Name = "suhani";
            emp2.Salary= 5;
            emp2.display();

            Employee emp4;
            emp4.Id = 4;
            emp4.Name = "akansha";
            emp4.Salary = 5;
            emp4.display();

        }
    }
    public struct Employee
    {
        public int Id;
        public string Name;
        public int Salary;
        public static int count;

        public Employee(int id, string name, int salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
            Salary = 0;
        }

        public void display()
        {
       
            Console.WriteLine("Id : {0}, Name: {1},Salary : {2} ",Id, Name, Salary);
        }
        public static void EmpCount()
        {
            Console.WriteLine(count);
        }
    }
}
