/* *********************************************************************** 
 * Project:     SortingAlgorithims 
 * File:        BubbleSort
 * Language:    C# 
 * 
 * Description: This class implements a Bubble sort 
 *             
 * College: Husson Unvirsity 
 * Course: IT 325 
 * 
 * Edit History; 
 * Ver   Who  Date       Notes 
 * ----  ---- ------     -----------------------------------
 * 0.1   BL  11-18-22      Inital writing 
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
    internal class BubbleSort
    {
        #region data 
        #endregion data 

        #region properties 
        #endregion properties  

        #region constructor 
        #endregion constructor

        #region methods  
        /// <summary>
        /// this method will sort an array of integers using a bubble sort 
        /// </summary>
        /// <param name="data"></param>
        public static void Sort(int[] data)
        {
            // make n-1 passes
            for (int pass = 0; pass < data.GetUpperBound(0); pass++)
            {
                // for each pass examine adj elements
                for (int index = 0; index < data.GetUpperBound(0) - pass; index++)
                {
                    // out of order check 
                    if (data[index] > data[index + 1])
                    {
                        Swap(data, index, index + 1);
                    }
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
