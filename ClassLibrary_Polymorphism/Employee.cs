using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Polymorphism
{
    public class Employee
    {
        private string emp_code;
        protected string Emp_Code
        {
            get { return emp_code; }
            set { emp_code = value; }
        }



        private string emp_name;



        protected string Emp_Name
        {
            get { return emp_name; }
            set { emp_name = value; }
        }



        private int emp_salary;



        protected int Emp_Salary
        {
            get { return emp_salary; }
            set { emp_salary = value; }
        }



        public Employee(string emp_code, string emp_name, int emp_salary)
        {
            while (!emp_code.Check_Code())
            {
                Console.WriteLine("Please enter code in Bs- format");
                emp_code = Console.ReadLine();
            }
            this.emp_code = emp_code;
            this.emp_name = emp_name;
            this.emp_salary = emp_salary;
        }



        public void Display()
        {
            Console.WriteLine("Emp code: {0}, Emp Name: {1}, Emp Salary: {2}", emp_code, emp_name, emp_salary);
        }



        public void TotalSalary()
        {
            Console.WriteLine("The cumulative salary for the year is {0}", emp_salary * 12);
        }



        public virtual void EmpDescription()
        {
            Console.WriteLine("I am an Employee, who has joined less than 6 months back");
        }



    }



    public class PermEmployee : Employee
    {



        private int bonus;



        public int Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }



        public PermEmployee(string code, string name, int salary, int bonus) : base(code, name, salary)
        {
            this.bonus = bonus;
        }



        public new void Display() //new keyword bcoz base class has same method
        {
            Console.WriteLine("The bonus is : {0}", bonus);
        }
        public override void EmpDescription()
        {
            Console.WriteLine("I am a Permanent Employee now and I have bonus");
        }

        public override string ToString()
        {
            return String.Format("PermEmployee values:\nEmployee Code: {0},\nEmployee Name: {1}, " +
                "Employee Salary: {2}, Bonus{3}", Emp_Code, Emp_Name, Emp_Salary, Bonus);
        }



    }
    public static class StirngExtinction
    {
        public static bool Check_Code(this string s)
        {
            if (s.StartsWith("Bs-"))
                return true;
            else
                return false;
        }
    }
    public abstract class TestAbstract
    {

        public abstract void AbstractMethod();
        public abstract void AbstractMethod2();
        //public abstract void AbstractMethod3() { } cuz body gives error
    }
    public class AbstractChid : TestAbstract
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("abs method 1");
        }
        public override void AbstractMethod2()
        {
            Console.WriteLine("abs method 2");
            Console.WriteLine("CustomerId: {0}, customerName: {1}", customerID, customerName);
        }

        public int customerID { get; set; }
        public string customerName { get; set; }

        public AbstractChid()
        {
            customerID = 1;
            customerName = "Vidya";
        }

    }
    public class Author
    {
        public string Name { get; set; }
        public string Book { get; set; }
        public string publisher { get; set; }
        public Int16 year { get; set; }
        public double Price { get; set; }
    }


    public partial class Employee1
    {
        partial void AddEmp();
        partial void EditEmp()
        {
            Console.WriteLine("This is edit method");
        }
        public void callPartial()
        {
            AddEmp();
            EditEmp();

        }
    }
}
