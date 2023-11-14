using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Console_Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1[0] = 1;
            e1[1] = "emp1";
            e1[2] = "Manager";
            e1[3] = 300000f;
            Console.WriteLine(e1[0]+" " + e1[1]+" " + e1[2]+" " + e1[3]);

            IndexerTest test1 = new IndexerTest();
            test1[0] = "cs";
            test1[1] = "java";
            test1[2] = "asp.net";
            
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(test1[i]);
            }
            test1.mynum = 1;
            Console.WriteLine("mynum: {0}", test1.mynum) ;
            Console.ReadLine();
        }
    }public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        float salary { get; set; }

        public Employee() { }
        public object this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return Id;
                }
                else if (index == 1)
                {
                    return Name;
                }
                else if (index == 2)
                {
                    return Designation;
                }
                else if (index == 3)
                {
                    return salary;
                }
                return null;

            }
            set
            {
                if (index == 0)
                {
                    Id = (int)value;
                }
                else if (index == 1)
                {
                    Name = (string)value;
                }
                else if (index == 2)
                {
                    Designation = (string)value;
                }
                else if (index == 3)
                {
                    salary = (float)value;
                }

            }

        }
    }
    public class IndexerTest
    {
        private string[] mystr = new string[3];
        public int mynum {  get; set; }
        public string this[int index]
        {
            get { return mystr[index]; }
            set { mystr[index] = value; }
        }
    }
    

}
