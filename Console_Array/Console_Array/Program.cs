using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //boxing and unboxing
            int box = 1;
            Object obj = box;
            int unbox=(int)obj;
            Console.WriteLine("Num: {0}, Obj: {1}, AnotherNum: {2}",box,obj,unbox);

            //arrays - single dimension
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int[] arr2 = new int[]{ 10, 20, 30, 40, 50, 60 };
            int[] arr3 = new int[3];
            arr3[0] =100;
            Console.WriteLine("values of single dimension array :");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            int[,] mularr = new int[2, 3];
          
            for(int rows = 0;rows < mularr.GetLength(0); rows++) {
            for(int cols = 0;cols < mularr.GetLength(1);cols++)
                {
                    Console.WriteLine("enter values of mularr[{0},{1}]",rows, cols );
                    mularr[rows,cols] = int.Parse(Console.ReadLine());
                }
                    }
            for (int rows = 0; rows < mularr.GetLength(0); rows++)
            {
                for (int cols = 0; cols < mularr.GetLength(1); cols++)
                {
                    Console.Write(mularr[rows, cols]+" ");
                   
                }Console.WriteLine();
            }

            //jagged array
            int[][] jaggedArr = new int[3][];
            jaggedArr[0] = new int[2] { 1, 2 };
            jaggedArr[1] = new int[3] { 10, 20, 30 };
            jaggedArr[2] = new int[4] {100,200,300,400};
            Console.WriteLine("Printing Jagged Arrays");
            for(int i=0; i < jaggedArr.Length; i++)
            {
                for(int j=0;j< jaggedArr[i].Length; j++)
                {
                    Console.Write(jaggedArr[i][j]+"\t");
                }Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
