using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 10;

            int[] studentIDs = new int[10];
            Random rNumber = new Random();

            //generate random numbers to fill the array
            for (int index = 0; index < SIZE; index++)
            {
                studentIDs[index] = rNumber.Next(10, 100);
            }

            Console.WriteLine("The list of student IDs is:");
            Display(studentIDs);
            Console.WriteLine();

            Console.Write("Enter a student ID or 0 to quit: ");
            int searchInt = Convert.ToInt32(Console.ReadLine());

            while (searchInt != 0)
            {
                //perform the linear search
                int position = LinearSearch(studentIDs, searchInt);

                Console.WriteLine();

                if (position == -1)
                {
                    Console.WriteLine("The ID " + searchInt + " was not found");
                }
                else
                {
                    Console.WriteLine("The ID " + searchInt + " was found in position " + position);
                }
                Console.WriteLine();

                Console.Write("Enter an ID (or 0 to quit): ");
                searchInt = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }

        //method to output values in the array
        static void Display(int[] studentIDs)
        {
            string temp = string.Empty;

            for (int index = 0; index < studentIDs.Length; index++)
            {
                Console.WriteLine("Index: " + index + "  ID: " + studentIDs[index]);
            }
        }

        //perform a linear search of the array
        static int LinearSearch(int[] studentIDs, int searchKey)
        {
            //loop through arrray sequentially
            for (int index = 0; index < studentIDs.Length; index++)
            {
                if (studentIDs[index] == searchKey)
                {
                    //return index of found integer
                    return index;
                }
            }
            //integer was not found
            return -1;
        }

    }
}
