using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewClassLibrary1
{
    public class Pointer
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Pointer()
        {
            Console.WriteLine("Enter a pointer X:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a pointer Y:");
            int y = int.Parse(Console.ReadLine());
            this.x = x;
            this.y = y;
            counter++;
        }
        public Pointer(int x, int y)
        {
            this.x = x;
            this.y = y;
            counter++;
        }
        public Pointer(Pointer p)
        {
            x = p.X;
            y = p.Y;
            counter++;
        }
        public Pointer(int x)
        {
            this.x = x;
            Y = 2;
            counter++;
        }

        private static int counter;
        public static int Counter
        {
            get { return counter; }
            set {  counter = value; }
        }
        static Pointer()
        {
            counter = 0;
            Console.WriteLine("in static constructor");
            counter++;
        }

        //method to display values:

        public void display()
        {
            Console.WriteLine("The values of x:  {0} , y : {1} ", x, y);
        }
        
        //destructor syntax--
        ~Pointer() { }
    }
}