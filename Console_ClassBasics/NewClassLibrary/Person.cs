using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NewClassLibrary
{
    public class Person
    {
        private int id;
        private string name;
        private char gender;
        private int age;

        public int Id
        { 
            //naming convention capital name of variable
            get { return id; } //getter proprerty
            set { id = value; } //setter property
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 18)
                    age = value;
                else age = 0;
            }
        }

        //Non Parameterised constructors-Default
        public Person()
        {
            Console.WriteLine("Enter the Person Id");
            id=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter person name");
            name=Console.ReadLine();
            Console.WriteLine("Enter person gender");
            gender=char.Parse(Console.ReadLine());
            Console.WriteLine("Enter person age");
            age=int.Parse(Console.ReadLine());
        }

        //Parameterized constructor


        public Person(int id, string name, char gender, int age)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.age = age;

        }

        //constructor overloading
        public Person(int id, string name, char gender)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            age = 18;
        }

        //copy constructor-we can give another obj as parameter
        public Person( Person p)
        {
            id=p.id;
            name=p.name;
            gender=p.gender;
            age = p.age;
        }
    }
}
