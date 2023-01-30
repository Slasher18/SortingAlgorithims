/* *********************************************************************** 
 * Project:     SortingAlgorithims 
 * File:        Sorting Algorithims demo
 * Language:    C# 
 * 
 * Description: This program will demostrate mutiple sorting  
 *             
 * College: Husson Unvirsity 
 * Course: IT 325 
 * 
 * Edit History; 
 * Ver   Who  Date       Notes 
 * ----  ---- ------     -----------------------------------
 * 0.1   BL  11-16-22      Inital writing 
 *                       
 * 0.2   BL  11-18-22      Added inline bubble sort  
 * 
 * 0.3   BL  12-2-22       Added insertion sort 
 * ***********************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithims
{
    public partial class FormSorting : Form
    {
        #region data 
        private int[] valueArray = { 57, 63, 40, 13, 74, 99, 21, 8 };

        #endregion data 

        #region properties 
        #endregion properties  

        #region constructor  
        public FormSorting()
        {
            InitializeComponent();
        }
        #endregion constructor

        #region methods 
        /// <summary>
        /// This routine will display the array of data in the listbox
        /// </summary>
        /// <param name="data"></param>
        public void BubbleSortFunction(int[] data)
        {
            // make n-1 passes through the array data 
            for (int pass = 0; pass < data.GetUpperBound(0); pass++)
            {
                // for each pass compare adjacnet values starting from the left 
                for (int index = 0; index < data.GetUpperBound(0) - pass; index++)
                {
                    // bubble the largest remaing value to the top(right) of the array
                    if (data[index] > data[index + 1])
                    {
                        // wrong order swap 
                        Swap(data, index, index+1);
                    }
                }
            }
        }

        /// <summary>
        /// This routine will display the array of data in the listbox 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="theListBox"></param>
        private void DisplayData(int[] data, ListBox theListBox)
        {
            theListBox.Items.Clear();

            theListBox.Items.Add("[index] = value");

            for (int index = 0; index <= data.GetUpperBound(0); index++)
            {
                // display each item in the array in the listbox 
                theListBox.Items.Add(String.Format("[{0}] = {1}", index, data[index]));
            }
        }

        public void Swap(int[] data, int firstIndex, int secondIndex)
        {
            int temp; 

            temp = data[firstIndex];
            data[firstIndex] = data[secondIndex];
            data[secondIndex] = temp;
        }
        #endregion methods 

        #region events   
        /// <summary>
        /// When the user clicks this button sort the data using the bubble sort class
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBubbleSortClass_Click(object sender, EventArgs e)
        {
            // display unsorted data
            DisplayData(valueArray, listBoxBeforeSort);

            // sort the data 
            BubbleSort.Sort(valueArray);

            // display sorted data
            DisplayData(valueArray, listBoxAfterSort);
        }
        /// <summary>
        /// sort the data using the bubble sort generic class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBubbleSortGeneric_Click(object sender, EventArgs e)
        {
            // display unsorted data
            DisplayData(valueArray, listBoxBeforeSort);

            // sort the data 
            BubbleSortGeneric.Sort(valueArray);

            // display sorted data
            DisplayData(valueArray, listBoxAfterSort);
        }

        /// <summary>
        /// When the user clicks this button sort the data using a bubble sort 
        /// function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBubbleSortFunction_Click(object sender, EventArgs e)
        {
            // display unsorted data
            DisplayData(valueArray, listBoxBeforeSort);

            // sort the data 
            BubbleSortFunction(valueArray);

            // display sorted data
            DisplayData(valueArray, listBoxAfterSort);

        }

        /// <summary>
        /// When the user clicks this button sort the data using an inline 
        /// bubble sort
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBubbleInline_Click(object sender, EventArgs e)
        {
            // display unsorted data
            DisplayData(valueArray, listBoxBeforeSort);

            // sort the data 
            int temp;     // temp storage for the swap 
            // make n-1 passes through the array data 
            for (int pass = 0; pass < valueArray.GetUpperBound(0); pass++)
            {
                // for each pass compare adjacnet values starting from the left 
                for (int index = 0; index < valueArray.GetUpperBound(0)-pass; index++)
                {
                    // bubble the largest remaing value to the top(right) of the array
                    if (valueArray[index] > valueArray[index + 1])
                    {
                        // wrong order swap 
                        
                        temp = valueArray[index];
                        valueArray[index] = valueArray[index + 1];
                        valueArray[index + 1] = temp;
                    }
                }
            }
            DisplayData(valueArray, listBoxAfterSort);
        }

        private void buttonInsertionSort_Click(object sender, EventArgs e)
        {
            // display unsorted data
            DisplayData(valueArray, listBoxBeforeSort);

            // sort the data 
            InsertionSort.Sort(valueArray);

            // display sorted data
            DisplayData(valueArray, listBoxAfterSort);
        }

        private void buttonMergeSort_Click(object sender, EventArgs e)
        {
            // display unsorted data
            DisplayData(valueArray, listBoxBeforeSort);

            listBoxBeforeSort.Items.Add(MergeSort.IsSorted(valueArray));

            // sort the data 
            MergeSort.Sort(valueArray);

            // display sorted data
            DisplayData(valueArray, listBoxAfterSort);
            listBoxAfterSort.Items.Add(MergeSort.IsSorted(valueArray));
        }

        private void buttonSelectionSort_Click(object sender, EventArgs e)
        {
            // display unsorted data
            DisplayData(valueArray, listBoxBeforeSort);

            // sort the data 
            SelectionSort.Sort(valueArray);
            

            // display sorted data
            DisplayData(valueArray, listBoxAfterSort);

        }


        #endregion events


        private void listBoxAfterSort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
