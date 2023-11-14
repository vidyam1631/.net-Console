using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Console_CollectionFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************ArrayList**********************");
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add("three");
            arrayList.Add('a');
            arrayList.Add(new Student());
            DisplayarrayList(arrayList);
            Console.WriteLine("the total no of elements are: {0}", arrayList.Count);
            arrayList.RemoveAt(2);
            Console.WriteLine("========arraylist after removal=============");
            Console.WriteLine("Index of element a in arrayList is :{0}", arrayList.IndexOf('a'));
            arrayList.Insert(3, 33);
            Console.WriteLine("========arraylist after insertion=============");
            DisplayarrayList(arrayList);

            Console.WriteLine("***********************Stack**********************");
            Stack stack=new Stack();
            stack.Push(10);
            stack.Push(10.5);
            stack.Push('c');
            stack.Push("four");
            stack.Push(new Student());
            Console.WriteLine("========display stack=============");
            DisplayStack(stack);
            Console.WriteLine("\nThe top element is {0} -using Pop()",stack.Pop());
            Console.WriteLine("\nThe top element of now is {0} -using Peek()",stack.Peek());
            Console.WriteLine("\n ___________Display stack after one Pop() and one Peek() ___________________");
            DisplayStack(stack);

            Console.WriteLine("***********************Queue**********************");
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(10.5);
            queue.Enqueue('c');
            queue.Enqueue("four");
            queue.Enqueue(new Student());
            Console.WriteLine("========display stack=============");
            DisplayQueue(queue);
            Console.WriteLine("\nThe top element is {0} -using Dequeue()", queue.Dequeue());
            Console.WriteLine("\nThe top element of now is {0} -using Peek()", queue.Peek());
            Console.WriteLine("\n ___________Display stack after one Dequeue() and one Peek() ___________________");
            DisplayQueue(queue);

        }
        public static void DisplayarrayList(ArrayList arrayList)
        {
            foreach (object obj in arrayList)
            {
                Console.WriteLine(obj);
            }
        }

        public static void DisplayStack(Stack stack)
        {
            foreach (object obj in stack)
            {
                Console.WriteLine(obj);
            }
        }
        public static void DisplayQueue(Queue queue)
        {
            foreach (object obj in queue)
            {
                Console.WriteLine(obj);
            }
        }
        public class Student
        {
            public string Name { get; set; }
            public string RollNo { get; set; }
        }
    }
}
