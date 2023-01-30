/* *********************************************************************** 
 * Project:     SortingAlgorithims 
 * File:        SelectionSort
 * Language:    C# 
 * 
 * Description: This class implements a selection sort 
 *             
 * College: Husson Unvirsity 
 * Course: IT 325 
 * 
 * Edit History; 
 * Ver   Who  Date       Notes 
 * ----  ---- ------     -----------------------------------
 * 0.4   BL  12-5-22      Inital writing 
 *                       - copied everything from insertion sort 
 *                         
 * 
 * ***********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithims
{
    internal class SelectionSort
    {
        #region data 
        #endregion data 

        #region properties 
        #endregion properties  

        #region constructor 
        #endregion constructor

        #region methods 
        /// <summary>
        /// This method uses an selection sort to sort an array of data
        /// </summary>
        /// <param name="data"></param>
        public static void Sort(int[] data)
        {
            Sort(data, data.GetLowerBound(0), data.GetUpperBound(0));

        }
        /// <summary>
        /// This mehtod uses a selecton sort to sort a portion of an array 
        /// of data defined by lower and upper index inclusive 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        public static void Sort(int[] data, int lower, int upper)
        {
            int maxValueIndex;     // index of max unsorted value 

            // make one pass for each item in the array 
            for (int pass = lower; pass <= upper; pass++)
            {
                // assume the first value is largest
                maxValueIndex = lower;
                // find any larger values 
                for (int index = lower; index <= upper - (pass - lower); index++)
                {
                    // check the value 
                    if (data[index].CompareTo(data[maxValueIndex]) > 0)
                    {
                        maxValueIndex = index;

                    }
                } 
                // done with this pass swap the max into position 
                Swap(data, maxValueIndex, upper - (pass - lower));
            }


        }


        /// <summary>
        /// This routine will swap the two array elements specified and first and second index 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="firstIndex"></param>
        /// <param name="secondIndex"></param>
        private static void Swap(int[] data, int firstIndex, int secondIndex)
        {
            int temp;
            temp = data[firstIndex];
            data[firstIndex] = data[secondIndex];
            data[secondIndex] = temp;
        }
        #endregion methods


    }
}
