using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewClassLibrary;

namespace Console_ClassBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();

            //set properties of person1
            person1.Id = 1;
            person1.Name = "Vidya";
            person1.Gender = 'F';
            person1.Age = 20;
            Console.WriteLine("Hello {0}, having Id {1}, having gender {2} and your age is {3} ",person1.Name, person1.Id, person1.Gender, person1.Age);

            //create  a person object using constructor
            Console.WriteLine("*******************************Person using Parametrless constructor***************************************");
            Person person2 = new Person();
            Console.WriteLine("Hello {0}, having Id {1}, having gender {2} and your age is {3} ", person2.Name, person2.Id, person2.Gender, person2.Age);

            Console.WriteLine("*******************************Person using Parameterized constructor***************************************");
            Person person3 = new Person(3,"suhani",'F',21);
            Console.WriteLine("Hello {0}, having Id {1}, having gender {2} and your age is {3} ", person3.Name, person3.Id, person3.Gender, person3.Age);

            Console.WriteLine("*******************************Person using Parameterized constructor***************************************");
            Person person4 = new Person(4, "suhani", 'F');
            Console.WriteLine("Hello {0}, having Id {1}, having gender {2} and your age is {3} ", person4.Name, person4.Id, person4.Gender, person4.Age);

            Console.WriteLine("*******************************Person using copy constructor***************************************");
            Person person5 = new Person(person2);
            Console.WriteLine("Hello {0}, having Id {1}, having gender {2} and your age is {3} ", person5.Name, person5.Id, person5.Gender, person5.Age);

            Account account = new Account();
            account.AccNo = 1;
            account.HolderName = "Vidya";
            account.Balance = 5000;
            Console.WriteLine("hello {0} your acc no is {1} and your balance is {2}", account.HolderName,account.AccNo, account.Balance);
        }

    }
    
    
    
}
