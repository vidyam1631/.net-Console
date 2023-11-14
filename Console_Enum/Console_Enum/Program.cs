using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Enum
{
    enum WeekDays { Mon = 1, Tues, Wed, Thu, Fri };
    enum Salutation { Mr, Mrs, Ms, Dr, Prof };
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The First Weekday is{0}", WeekDays.Mon);
            Console.WriteLine("tHE integer value of the First weekday is {0}", (int)WeekDays.Mon);

            String name;
            int choice;
            Salutation salute=0;

            Console.WriteLine("enter your name");
            name=Console.ReadLine();

            Console.WriteLine(" 1.Mr \n 2.Mrs \n 3. Ms \n 4. Dr \n 5. Prof");
            Console.WriteLine("enter a sr no 1-5 for salutation");
            choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    salute = Salutation.Mr;
                    break;
                case 2:
                    salute = Salutation.Mrs;
                    break;
                case 3:
                    salute = Salutation.Ms;
                    break;
                case 4:
                    salute = Salutation.Dr;
                    break;
                case 5:
                    salute = Salutation.Prof;
                    break;
                default: 
                    salute = Salutation.Mr;
                    break;
            }
            Console.WriteLine("WELCOME to world of c# {0} {1} ", salute, name);

            Console.WriteLine("Please enter your salutation Mr,Mrs,Ms,Dr,Prof");
            salute =(Salutation)Enum.Parse(typeof(Salutation), Console.ReadLine());

            Console.WriteLine("welcome again {0} {1}", salute,name);
            
            Console.ReadLine();
        }
    }
}
