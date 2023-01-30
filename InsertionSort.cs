/* *********************************************************************** 
 * Project:     SortingAlgorithims 
 * File:        InsertionSort
 * Language:    C# 
 * 
 * Description: This class implements a insertion sort 
 *             
 * College: Husson Unvirsity 
 * Course: IT 325 
 * 
 * Edit History; 
 * Ver   Who  Date       Notes 
 * ----  ---- ------     -----------------------------------
 * 0.3   BL  12-2-22      Inital writing 
 *                       - borrowed swap from BubbleSort
 *                         
 * 
 * ***********************************************************************/
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithims
{
    internal class InsertionSort
    {
        #region data 
        #endregion data 

        #region properties 
        #endregion properties  

        #region constructor 
        #endregion constructor

        #region methods 
        /// <summary>
        /// This method uses an insertion sort to sort an array of data
        /// </summary>
        /// <param name="data"></param>
        public static void Sort(int[] data)
        {
            int lower;     // lower index of array portion to sort 
            int upper;     // upper index of array portion to sort
            int key;       // value we are trying to insert into the sorted array 
            int searchIndex;    // index we are comparing to the key value 


            // initlize the boundries 
            lower = data.GetLowerBound(0);
            upper = data.GetUpperBound(0); 

            // make one pass for each item in the array bounds 
            for (int keyIndex = lower; keyIndex <= upper; keyIndex++)
            {
                // save off the key value -> value you want to put into the
                // correct postion in the sorted array [the key]

                key = data[keyIndex];
                // start looking one position to the right of the key 
                // and work left, becuase we swap larger values 
                searchIndex = keyIndex-1;
                while ((searchIndex >= lower) && (data[searchIndex].CompareTo(key) > 0))
                {
                    Swap(data, searchIndex, searchIndex+1);
                    searchIndex--;
                }
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
