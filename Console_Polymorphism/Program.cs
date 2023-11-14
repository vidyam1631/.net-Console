using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_Polymorphism;

namespace Console_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PermEmployee p1 = new PermEmployee("Bs-1", "Akansha", 40000, 5000);


            p1.Display();

            p1.EmpDescription();

            p1.TotalSalary();

            Console.WriteLine("===================Now Uisng Virtual and Override==============================");
            Employee p2 = new PermEmployee("B2--2", "Shyaam", 45000, 10000);
            p2.Display();
            p2.EmpDescription();
            p2.TotalSalary();
            Console.WriteLine();



            Employee p3 = new Employee("B2--2", "Shyaam", 45000);
            p3.Display();
            p3.EmpDescription();
            p3.TotalSalary();

            Console.WriteLine("============to string==============");
            Console.WriteLine(p1.ToString());

            AbstractChid abs = new AbstractChid();
            abs.AbstractMethod2();

            //syntax for object initializers
            Author author = new Author() {
             Name = "Vidya",
                Book = "Link programming",
                publisher = "APress",
            year = 2023,
            Price = 200
            };
            Console.WriteLine("Name: {0}, Book: {1}, Publisher: {2}, Year: {3}, Price: {4}", author.Name, author.Book, author.publisher, author.Price, author.year );

            var Person = new { Name = "Vidyya", Age = 22 };
            Console.WriteLine("Name: {0}, Age: {1}", Person.Name, Person.Age);

            Employee1 e1 = new Employee1();
            e1.callPartial();
            Console.ReadLine();
        }
    }
}
