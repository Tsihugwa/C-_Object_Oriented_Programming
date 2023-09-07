using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentSortA
{
    class Program
    {
        static void Main(string[] args)
        {
            String [] names = new string[] {"Smith","Holmes","Warren","Brown","Kelly",
                                            "Young","Jackson","Hart","Manwar","Little"};
           //display unsorted array
            Console.WriteLine("Unsorted . . . ."); 
            Display(names);
            Console.WriteLine();
          
            //sort the array
            SelectionSort(names);

            //display sorted array
            Console.WriteLine("Sorted . . . . .");
            Display(names);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        
        //sort array using selection sort
        static void SelectionSort(string [] names)
        {
            int smallest; // index of smallest element

            for (int i = 0; i < names.Length-1; i++)
            {
                smallest = i;
                //loop to find index of smallest element
                for (int index = i + 1; index < names.Length; index++)
                {
                    if (names[index].CompareTo(names[smallest]) < 0)
                    {
                        smallest = index;
                    }
                }
                //swap smallest element into position
                string temp = names[i];
                names[i] = names[smallest];
                names[smallest] = temp;
             }
        } 

        //display array values
        static void Display(string [] names)
        {
            for (int index = 0; index < names.Length; index++)
            {
                Console.WriteLine(names[index]);
            }
        } 

    }
}
