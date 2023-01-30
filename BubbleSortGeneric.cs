/* *********************************************************************** 
 * Project:     SortingAlgorithims
 * File:        BubbleSortGeneric
 * Language:    C# 
 * 
 * Description: This class implements of a bubble sort using generics
 *             
 * College: Husson Unvirsity 
 * Course: IT 325 
 * 
 * Edit History; 
 * Ver   Who  Date       Notes 
 * ----  ---- ------     -----------------------------------
 * 0.4   BL  11-21-22      Inital writing 
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
    internal class BubbleSortGeneric
    {
        #region data 
        #endregion data 

        #region properties 
        #endregion properties  

        #region constructor 
        #endregion constructor

        #region methods  
        public static void Sort<T>(T[] data) where T : IComparable
        {
            for (int pass = 0; pass < data.GetUpperBound(0); pass++)
            {
                for (int index = 0; index < data.GetUpperBound(0) - pass; index++)
                {
                    if (data[index].CompareTo(data[index + 1]) > 0)
                    {
                        // swap them, they out of order my man
                        Swap(data, index, index + 1);
                    }
                }
            }
            
        }

        private static void Swap<T>(T[] data, int firstIndex, int secondIndex)
        {
            T temp;
            temp = data[firstIndex];
            data[firstIndex] = data[secondIndex];
            data[secondIndex] = temp;
        }
        #endregion methods
    }
}
