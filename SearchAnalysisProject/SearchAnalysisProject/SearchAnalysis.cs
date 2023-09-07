using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SearchAnalysisProject
{
    class SearchAnalysis
    {
        #region Private data members

        private int[] data;                 //array of numbers to be searched
        private int[] searchKeys;           //array to hold the random search keys
        private int[] linearComparisons;    //comparisons made in linear search
        private int[] binaryComparisons;    //comparisons made on binary search

        private static Random rNumber = new Random();    

        #endregion

         //constructor
        public SearchAnalysis(int size, int search)
        {
            //instantiate the arrays
            data = new int[size];
            searchKeys = new int[search];
            linearComparisons = new int[search];
            binaryComparisons = new int[search];


            //generate random numbers to fill the data array
            for (int i = 0; i < size; i++)
            {
                data[i] = rNumber.Next(10, 100);
            }

            //generate random numbers to fill search keys array
            for (int i = 0; i < search; i++)
            {
                searchKeys[i] = rNumber.Next(10, 100);
            }

            //binary search only works on a sorted array
            Array.Sort(data);
        }

        //perform a linear search of the array and count comparisons
        public void LinearSearchCount()
        {
            //initialise counter and flag
            int index = 0;
            bool found = false;
            Console.WriteLine("Performing linear search . . .");
            Console.WriteLine();

            for (int i = 0; i < searchKeys.Length; i++)
            {
                while (index < data.Length && !found)
                {
                    //trace line; remove when running with large arrays
                    Console.WriteLine("Search key: " + searchKeys[i] + " Array: " + data[index]);

                    //check if the search key is found at current location in data array
                    if (data[index] == searchKeys[i])
                    {
                        //return number of comparisons and set flag
                        linearComparisons[i] = index + 1;
                        found = true;
                    }
                    index++;  //increment index
                } //end while

                if (!found)  //search key was not found
                {
                    //number of comparisons was the maximum possible
                    linearComparisons[i] = data.Length;

                }

                //display number of comparisons for this search
                Console.WriteLine();
                Console.WriteLine("Search number: " + (i + 1) + " Comparisons: " + linearComparisons[i]);
                Console.WriteLine();

                //reset index counter and flag
                index = 0;
                found = false;
            } //end for

        }// end method LinearSearchCount

        //perform a binary search of the data and count comparisons
        public void BinarySearchCount()
        {
            //initialise counter and flag
            int index = 0;
            bool found = false;

            Console.WriteLine("Performing binary search . . .");
            Console.WriteLine();

            for (int i = 0; i < searchKeys.Length; i++)
            {
                //set indexes for binary searching
                int low = 0;                          //low end of the search area
                int high = data.Length - 1;          //high end of search area
                int middle = (low + high + 1) / 2;  //middle element

                //set counter for current element of Comparisons Array
                binaryComparisons[i] = 0;

                while (!found && low <= high)
                {
                    //trace line; remove when running with large arrays
                    Console.WriteLine("Search key: " + searchKeys[i] + " Array: " + data[middle]);

                    //increment number of comparisons                
                    binaryComparisons[i] += 1;

                    //if the search element is found at the middle
                    if (searchKeys[i] == data[middle])
                    {
                        found = true;    //set flag  
                    }
                    else //keep searching
                    {
                        if (searchKeys[i] < data[middle])  //middle element is too high
                        {
                            high = middle - 1;  //eliminate the upper half
                        }
                        else
                        {
                            low = middle + 1;   //eliminate the lower half
                        }
                        //recalculate the middle value
                        middle = (low + high + 1) / 2;
                    }

                    index++;  //increment index
                } //end while

                //display number of comparisons for this search
                Console.WriteLine();
                Console.WriteLine("Search number: " + (i + 1) + " Comparisons: " + binaryComparisons[i]);
                Console.WriteLine();

                //reset index counter and flag
                index = 0;
                found = false;
            } //end for
        } // end method BinarySearch

        //method to calculate average number of linear comparisons
        public double LinearComparisons()
        {
            int linearTotal = 0;
            for (int i = 0; i < linearComparisons.Length; i++)
            {
                //add up the total number of comparisons made
                linearTotal += linearComparisons[i];
            }
            return (double)linearTotal / searchKeys.Length; //return average
        } // end method LinearComparisons

        //method to calculate average number of binary comparisons
        public double BinaryComparisons()
        {
            int binaryTotal = 0; 
            for (int i = 0; i < binaryComparisons.Length; i++)
            {
                //add up the total number of comparisons made
                binaryTotal += binaryComparisons[i];
            }
            return (double)binaryTotal / searchKeys.Length; //return average
        } //end method BinaryComparisons

        //method to output values in the array
        public override string ToString()
        {
            string temp = string.Empty;

            //loop through array
            foreach (int element in data)
                temp += element + " ";

            temp += Environment.NewLine;
            return temp;

        } //end method ToString

    }
}
