/* *********************************************************************** 
 * Project:     Sorting Algorthims 
 * File:        Merge sort class
 * Language:    C# 
 * 
 * Description: This class implements a node pointer
 *             
 * College: Husson University 
 * Course: IT 326 
 * 
 * Edit History; 
 * Ver   Who  Date       Notes 
 * ----  ---- ------     -----------------------------------
 * 0.1   BL  1-25-23      Inital writing 
 *                         
 * 
 * ***********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithims
{
    internal class MergeSort
    {
        #region data 
        #endregion data 

        #region properties 
        #endregion properties  

        #region constructor 
        #endregion constructor

        #region methods 
        /// <summary>
        /// This routine will traverse the array to detemine if it is sorted 
        /// </summary>
        /// <param name="data"></param>
        /// <returns> True-- if array is sorted 
        ///           False-- if arrau isnt sorted  </returns>
        public static bool IsSorted(int[] data)
        {
            bool arrayIsSorted = true; 
            int index = data.GetLowerBound(0);

            // check each element to see if in sorted order 
            while ((index < data.GetUpperBound(0)) && (arrayIsSorted))
            {
                if (data[index].CompareTo(data[index+1])>0)
                {
                    arrayIsSorted = false;
                }
                else
                {
                    index++;
                }
            }
            // return the result 
            return arrayIsSorted;
        }

        /// <summary>
        /// this method will merge the 2 subsections of the array defined by 
        /// left through middle, and middle +1 through right.
        /// It is assumed that the two subsections are already sorted 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="left"></param>
        /// <param name="middle"></param>
        /// <param name="right"></param>
        private static void Merge(int[] data, int left, int middle, int right)
        {
            // create temp storage 
            int[] temp = new int[right - left + 1];

            // create temp working index 
            int leftIndex = left;       // left is the leftmost item in the left subarray
            int rightIndex = middle +1;     // right is the leftmost item in the right subarray
            int tempIndex = 0;          // index is the first item in temp array 

            // traverse both arrays (left -> middle, middle+1 -> right) 
            // so long as they both have unsort data remaining 
            while ((leftIndex <= middle) && (rightIndex <= right))
            {
                if (data[leftIndex].CompareTo(data[rightIndex])<= 0)
                {
                    // left value is smaller, store in temp array 
                    temp[tempIndex] = data[leftIndex];
                    leftIndex++;
                    tempIndex++;
                    //temp[tempIndex++] = data[leftIndex++];  shortcut for 3 lines above

                }
                else
                {
                    // right value is smaller, store in temp array 
                    temp[tempIndex] = data[rightIndex];
                    rightIndex++;
                    tempIndex++;
                }
            }

            // process any remaining data in the left subarray 
            while (leftIndex <= middle)
            {
                temp[tempIndex] = data[leftIndex];
                leftIndex++;
                tempIndex++;
            }
            
            //process any remaining data in the right subarray 
            while (rightIndex <= right)
            {
                temp[tempIndex] = data[rightIndex];
                rightIndex++;
                tempIndex++;
            }

            // two subarrays have been merged 
            // traverse the temp array and store the data back in the oringal array 
            int mainIndex = left;
            for (tempIndex = temp.GetLowerBound(0); 
                tempIndex <= temp.GetUpperBound(0); tempIndex++)
            {
                data[mainIndex] = temp[tempIndex];
                mainIndex++;
            }

             


        }


        /// <summary>
        /// use merge sort to sort an array
        /// </summary>
        /// <param name="data"></param>
        public static void Sort(int[] data)
        {
            Sort(data, data.GetLowerBound(0), data.GetUpperBound(0));
        }

        /// <summary>
        /// use merge sort to sort a portion of the array, bounded by lower
        /// and upper array index specified (inclusive)
        /// </summary>
        /// <param name="data"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        public static void Sort(int[] data, int lower, int upper)
        {
            Split(data, lower, upper);
        }
        /// <summary>
        /// this method splits an array, if the size is greater than 1 
        /// into a left and right component and recursive calls itself
        /// When size is one, it will call a merge routine 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        private static void Split(int[] data, int left, int right)
        {
            // make sure there are at least 2 elements 
            // we are done spliting if only 1 element 

            if (left < right)
            {
                // calculate the middle 
                int middle = (left + right) / 2;

                // sort the left side 
                Split(data, left, middle);

                // sort the right side 
                Split(data, middle+1, right);

                // merge the 2 halves back together 
                Merge(data,left,middle, right);
            }
        }    
            
        #endregion methods
    }
}
