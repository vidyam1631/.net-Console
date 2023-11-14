using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_Interface;

namespace Console_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Crocodile croc1= new Crocodile();
           
            croc1.Walk();
            croc1.Swim();
            ITerrestial crocT = new Crocodile();
            crocT.Eat();
            IAquatic crocA = new Crocodile();
            crocA.Eat();
            Console.ReadLine();
        }
    }
}
