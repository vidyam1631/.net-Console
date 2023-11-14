using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Inheritance
{
    public class First
    {
        private int first_no;

        protected int First_No
        {
            get { return first_no; }
            set { first_no = value; }
        }
        //construcotor
        public First()
        {
            first_no = 1;
            Console.WriteLine("Inside first constructor");
        }
        public First(int first_no)
        {
            this.first_no = first_no;
            Console.WriteLine("Inside first parameterized constructor");
        }
        //method
        public void GetFirstValue()
        {
            Console.WriteLine("Inside GetValue()- Fisrst: first_no {0}",first_no);
        }
    }
    public class Second : First 
    {
        private int second_no;
        protected int Second_No
        {
            get { return second_no; }
            set { second_no = value; }
        }
        public Second()
        {
            second_no = 2;
            Console.WriteLine("Inside the second  constructor");
        }
        public Second(int second_no):base(second_no)// second_no value will be passed to base class 
        {
            this.second_no = second_no;
            Console.WriteLine("Inside the second  parameterized constructor");
        }
        public Second(int second_no, int f) : base(f)// first_no value will be passed to base class 
        {
            this.second_no = second_no;
            Console.WriteLine("Inside the second  parameterized constructor");
        }
        public void GetSecondValue()
        {
            Console.WriteLine("Inside GetValue()- Fisrst: first_no {0}", First_No);
            Console.WriteLine("Inside GetValue()- Second: second_no {0}", second_no);
        }
    }
    public class Third : Second
    {
        private int third_no;
        protected int Third_No
        {
            get { return third_no; }
            set { third_no = value; }
        }
        public Third()
        {
            third_no = 3;
            Console.WriteLine("Inside  the third constructor ");
        }
        public Third(int third_no, int s,int f ):base(s, f)
        {
            this.third_no = third_no;
            Console.WriteLine("Inside  the third parameterised constructor ");
        }
        public void GetThirdValue()
        {
            Console.WriteLine("Inside GetValue()- Fisrst: first_no {0}", First_No);
            Console.WriteLine("Inside GetValue()- Second: second_no {0}", Second_No);
            Console.WriteLine("Inside GetValue()- Third: third_no {0}", third_no);
        }
    }
}
