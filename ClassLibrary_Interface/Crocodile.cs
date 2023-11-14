using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Interface
{
    public class Crocodile:ITerrestial, IAquatic
    {
        void ITerrestial.Eat()
        {
            Console.WriteLine("The crocodile can eat fleash and other animals");
        }public void Walk()
        {
            Console.WriteLine("The crocodile can walk slowly on land");
        }
        void IAquatic.Eat()
        {
            Console.WriteLine("The crocodile can eat fish in water");
        }
        public void Swim()
        {
            Console.WriteLine("The crocodile swims slylly in water");
        }
    }
}
