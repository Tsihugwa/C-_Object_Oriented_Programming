using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SearchAnalysisProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //change these values to create a larger data array and/or number of searches
            int dataItems = 15;   //the number of items in the data array
            int searchKeys = 5;   //the number of times to search the data array

            double linearAverage;       //average number of linear comparisons per search
            double binaryAverage;       //average number of binary comparisons per search

            //create arrays and display data array
            SearchAnalysis SearchArray = new SearchAnalysis(dataItems, searchKeys);
            Console.Write("Data array contains: ");
            //trace line; remove for very large data sets
            Console.WriteLine(SearchArray);

            //perform linear search and calculate average number of comparisons
            SearchArray.LinearSearchCount();
            linearAverage = SearchArray.LinearComparisons();

            //perform binary search and calculate average number of comparisons
            SearchArray.BinarySearchCount();
            binaryAverage = SearchArray.BinaryComparisons();

            //display final analysis
            Console.WriteLine();
            Console.WriteLine("Comparison of linear and binary searching");
            Console.WriteLine();
            Console.WriteLine("Data array had " + dataItems + " elements. " + searchKeys + " searches were made");
            Console.WriteLine();

            //display linear average          
            Console.WriteLine("Linear search - average comparisons per search: " + linearAverage);
            Console.WriteLine();

            //display binary average
            Console.WriteLine("Binary search - average comparisons per search: " + binaryAverage);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
