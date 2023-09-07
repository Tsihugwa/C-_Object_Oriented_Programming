using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MergeSort
{
    class MergeSortClass
    {
        private int[] data;
        private static Random rNumber = new Random();

        //constructor
        public MergeSortClass(int size)
        {
            data = new int[size];

            //generate random numbers to fill the array
            for (int i = 0; i < size; i++)
            {
                data[i] = rNumber.Next(10, 100);
            }
        } 
        
        //call recursive SortArray method to begin merge sorting
        public void MergeSort()
        {
            SortArray(0, data.Length - 1);  //sort entire array
        } 

        //split array, sort subarrays and then merge into sorted array
        private void SortArray(int low, int high)
        {
            //test base case; size of array = 1
            if ((high - low) >= 1)//if not base case
            {
                int middle1 = (low + high) / 2;  //calculate middle of array
                int middle2 = middle1 + 1;   //calculate next element over

                //split array in half; sort each half recursively
                SortArray(low, middle1);   //first half of array
                SortArray(middle2, high);  //second half of array

                //merge two sorted arrays after split call returns
                Merge(low, middle1, middle2, high);
            }
        } 

        //merge two sorted subarrays into one sorted subarray
        private void Merge(int left, int middle1, int middle2, int right)
        {
            int leftIndex = left;           //index into left subarray
            int rightIndex = middle2;       //index into right subarray
            int combinedIndex = left;       //index into temporary working array
            int[] combined = new int[data.Length];  //working array

            //merge arrays until reaching end of either of them
            while (leftIndex <= middle1 && rightIndex <= right)
            {
                //place the smaller of the two current elements into result
                //and move to next space in arrays
                if (data[leftIndex] <= data[rightIndex])
                {
                    combined[combinedIndex++] = data[leftIndex++];
                }
                else
                {
                    combined[combinedIndex++] = data[rightIndex++];
                }
            }

            //if left array is empty
            if (leftIndex == middle2)
            {
                //copy in rest of the right array
                while (rightIndex <= right)
                {
                    combined[combinedIndex++] = data[rightIndex++];
                }
            }
            else //right array is empty
            {
                //copy in rest of the left array
                while (leftIndex <= middle1)
                {
                    combined[combinedIndex++] = data[leftIndex++];
                }
            }

            //copy values back into original array
            for (int i = left; i <= right; i++)
            {
                data[i] = combined[i];
            }
        }
     
        //method to output values in the array
        public override string ToString()
        {
            string temp = string.Empty;

            //loop through array
            foreach (int element in data)
                temp += element + Environment.NewLine;

            temp += Environment.NewLine;
            return temp;

        } 
    }
}
