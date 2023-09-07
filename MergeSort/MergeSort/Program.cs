using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //create object to perform merge sort
            MergeSortClass myArray = new MergeSortClass(10);

            //display unsorted array
            Console.WriteLine("Unsorted . . .");
            Console.WriteLine(myArray);          
            Console.WriteLine();

            //sort the array
            myArray.MergeSort();

            //display sorted array
            Console.WriteLine("Sorted . . .");
            Console.WriteLine(myArray);        

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
