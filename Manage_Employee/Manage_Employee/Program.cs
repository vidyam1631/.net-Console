using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Employee
{
    internal class Program

    {
        static void Main(string[] args)
        {
            bool continueMenu = true;
            do { 
            Console.WriteLine("Enter your choice: \n1. Add Employee\n2. Edit Employee\n3. Delete Employee\n4. View Employee\n5. Go Back\n6. Exit ");
            int choice=int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1: 
                    Console.WriteLine("Add Employee");
                    break;
                case 2:
                    Console.WriteLine("Edit Employee");
                    break;
                case 3:
                    Console.WriteLine("Delete Employee");
                    break;  
                case 4:
                    Console.WriteLine("View Employee");
                    break;
                case 5:
                    Console.WriteLine("Go Back");
                    break;
                case 6:
                    Console.WriteLine("Exiting the menu now");
                    continueMenu = false;
                    break;
                default: 
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            Console.WriteLine("Do you want to continue? (y/n)");
            char response = Console.ReadKey().KeyChar;
            Console.WriteLine("\n");
            continueMenu = (response == 'y' || response == 'Y');

        } while (continueMenu);
        }
    }
}
