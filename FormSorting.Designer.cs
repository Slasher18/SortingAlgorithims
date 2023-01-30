namespace SortingAlgorithims
{
    partial class FormSorting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelBeforeSort = new System.Windows.Forms.Label();
            this.labelAfterSort = new System.Windows.Forms.Label();
            this.listBoxBeforeSort = new System.Windows.Forms.ListBox();
            this.listBoxAfterSort = new System.Windows.Forms.ListBox();
            this.groupBoxBubbleSort = new System.Windows.Forms.GroupBox();
            this.buttonBubbleSortGeneric = new System.Windows.Forms.Button();
            this.buttonBubbleSortClass = new System.Windows.Forms.Button();
            this.buttonBubbleSortFunction = new System.Windows.Forms.Button();
            this.buttonBubbleInline = new System.Windows.Forms.Button();
            this.buttonInsertionSort = new System.Windows.Forms.Button();
            this.buttonSelectionSort = new System.Windows.Forms.Button();
            this.buttonMergeSort = new System.Windows.Forms.Button();
            this.groupBoxBubbleSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBeforeSort
            // 
            this.labelBeforeSort.AutoSize = true;
            this.labelBeforeSort.Location = new System.Drawing.Point(13, 13);
            this.labelBeforeSort.Name = "labelBeforeSort";
            this.labelBeforeSort.Size = new System.Drawing.Size(47, 16);
            this.labelBeforeSort.TabIndex = 0;
            this.labelBeforeSort.Text = "Before";
            // 
            // labelAfterSort
            // 
            this.labelAfterSort.AutoSize = true;
            this.labelAfterSort.Location = new System.Drawing.Point(327, 13);
            this.labelAfterSort.Name = "labelAfterSort";
            this.labelAfterSort.Size = new System.Drawing.Size(34, 16);
            this.labelAfterSort.TabIndex = 1;
            this.labelAfterSort.Text = "After";
            // 
            // listBoxBeforeSort
            // 
            this.listBoxBeforeSort.FormattingEnabled = true;
            this.listBoxBeforeSort.ItemHeight = 16;
            this.listBoxBeforeSort.Location = new System.Drawing.Point(12, 32);
            this.listBoxBeforeSort.Name = "listBoxBeforeSort";
            this.listBoxBeforeSort.Size = new System.Drawing.Size(301, 388);
            this.listBoxBeforeSort.TabIndex = 2;
            // 
            // listBoxAfterSort
            // 
            this.listBoxAfterSort.FormattingEnabled = true;
            this.listBoxAfterSort.ItemHeight = 16;
            this.listBoxAfterSort.Location = new System.Drawing.Point(330, 32);
            this.listBoxAfterSort.Name = "listBoxAfterSort";
            this.listBoxAfterSort.Size = new System.Drawing.Size(302, 388);
            this.listBoxAfterSort.TabIndex = 3;
            this.listBoxAfterSort.SelectedIndexChanged += new System.EventHandler(this.listBoxAfterSort_SelectedIndexChanged);
            // 
            // groupBoxBubbleSort
            // 
            this.groupBoxBubbleSort.Controls.Add(this.buttonBubbleSortGeneric);
            this.groupBoxBubbleSort.Controls.Add(this.buttonBubbleSortClass);
            this.groupBoxBubbleSort.Controls.Add(this.buttonBubbleSortFunction);
            this.groupBoxBubbleSort.Controls.Add(this.buttonBubbleInline);
            this.groupBoxBubbleSort.Location = new System.Drawing.Point(648, 32);
            this.groupBoxBubbleSort.Name = "groupBoxBubbleSort";
            this.groupBoxBubbleSort.Size = new System.Drawing.Size(226, 144);
            this.groupBoxBubbleSort.TabIndex = 4;
            this.groupBoxBubbleSort.TabStop = false;
            this.groupBoxBubbleSort.Text = "BubbleSort";
            // 
            // buttonBubbleSortGeneric
            // 
            this.buttonBubbleSortGeneric.Location = new System.Drawing.Point(79, 108);
            this.buttonBubbleSortGeneric.Name = "buttonBubbleSortGeneric";
            this.buttonBubbleSortGeneric.Size = new System.Drawing.Size(75, 23);
            this.buttonBubbleSortGeneric.TabIndex = 3;
            this.buttonBubbleSortGeneric.Text = "Generic";
            this.buttonBubbleSortGeneric.UseVisualStyleBackColor = true;
            this.buttonBubbleSortGeneric.Click += new System.EventHandler(this.buttonBubbleSortGeneric_Click);
            // 
            // buttonBubbleSortClass
            // 
            this.buttonBubbleSortClass.Location = new System.Drawing.Point(79, 79);
            this.buttonBubbleSortClass.Name = "buttonBubbleSortClass";
            this.buttonBubbleSortClass.Size = new System.Drawing.Size(75, 23);
            this.buttonBubbleSortClass.TabIndex = 2;
            this.buttonBubbleSortClass.Text = "Class";
            this.buttonBubbleSortClass.UseVisualStyleBackColor = true;
            this.buttonBubbleSortClass.Click += new System.EventHandler(this.buttonBubbleSortClass_Click);
            // 
            // buttonBubbleSortFunction
            // 
            this.buttonBubbleSortFunction.Location = new System.Drawing.Point(79, 50);
            this.buttonBubbleSortFunction.Name = "buttonBubbleSortFunction";
            this.buttonBubbleSortFunction.Size = new System.Drawing.Size(75, 23);
            this.buttonBubbleSortFunction.TabIndex = 1;
            this.buttonBubbleSortFunction.Text = "Function";
            this.buttonBubbleSortFunction.UseVisualStyleBackColor = true;
            this.buttonBubbleSortFunction.Click += new System.EventHandler(this.buttonBubbleSortFunction_Click);
            // 
            // buttonBubbleInline
            // 
            this.buttonBubbleInline.Location = new System.Drawing.Point(79, 21);
            this.buttonBubbleInline.Name = "buttonBubbleInline";
            this.buttonBubbleInline.Size = new System.Drawing.Size(75, 23);
            this.buttonBubbleInline.TabIndex = 0;
            this.buttonBubbleInline.Text = "Inline";
            this.buttonBubbleInline.UseVisualStyleBackColor = true;
            this.buttonBubbleInline.Click += new System.EventHandler(this.buttonBubbleInline_Click);
            // 
            // buttonInsertionSort
            // 
            this.buttonInsertionSort.Location = new System.Drawing.Point(727, 216);
            this.buttonInsertionSort.Name = "buttonInsertionSort";
            this.buttonInsertionSort.Size = new System.Drawing.Size(83, 23);
            this.buttonInsertionSort.TabIndex = 5;
            this.buttonInsertionSort.Text = "Insertion";
            this.buttonInsertionSort.UseVisualStyleBackColor = true;
            this.buttonInsertionSort.Click += new System.EventHandler(this.buttonInsertionSort_Click);
            // 
            // buttonSelectionSort
            // 
            this.buttonSelectionSort.Location = new System.Drawing.Point(727, 245);
            this.buttonSelectionSort.Name = "buttonSelectionSort";
            this.buttonSelectionSort.Size = new System.Drawing.Size(83, 23);
            this.buttonSelectionSort.TabIndex = 6;
            this.buttonSelectionSort.Text = "Selection";
            this.buttonSelectionSort.UseVisualStyleBackColor = true;
            this.buttonSelectionSort.Click += new System.EventHandler(this.buttonSelectionSort_Click);
            // 
            // buttonMergeSort
            // 
            this.buttonMergeSort.Location = new System.Drawing.Point(727, 274);
            this.buttonMergeSort.Name = "buttonMergeSort";
            this.buttonMergeSort.Size = new System.Drawing.Size(83, 26);
            this.buttonMergeSort.TabIndex = 7;
            this.buttonMergeSort.Text = "Merge";
            this.buttonMergeSort.UseVisualStyleBackColor = true;
            this.buttonMergeSort.Click += new System.EventHandler(this.buttonMergeSort_Click);
            // 
            // FormSorting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 450);
            this.Controls.Add(this.buttonMergeSort);
            this.Controls.Add(this.buttonSelectionSort);
            this.Controls.Add(this.buttonInsertionSort);
            this.Controls.Add(this.groupBoxBubbleSort);
            this.Controls.Add(this.listBoxAfterSort);
            this.Controls.Add(this.listBoxBeforeSort);
            this.Controls.Add(this.labelAfterSort);
            this.Controls.Add(this.labelBeforeSort);
            this.Name = "FormSorting";
            this.Text = "Sorting Algorithims";
            this.groupBoxBubbleSort.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBeforeSort;
        private System.Windows.Forms.Label labelAfterSort;
        private System.Windows.Forms.ListBox listBoxBeforeSort;
        private System.Windows.Forms.ListBox listBoxAfterSort;
        private System.Windows.Forms.GroupBox groupBoxBubbleSort;
        private System.Windows.Forms.Button buttonBubbleInline;
        private System.Windows.Forms.Button buttonBubbleSortFunction;
        private System.Windows.Forms.Button buttonBubbleSortClass;
        private System.Windows.Forms.Button buttonBubbleSortGeneric;
        private System.Windows.Forms.Button buttonInsertionSort;
        private System.Windows.Forms.Button buttonSelectionSort;
        private System.Windows.Forms.Button buttonMergeSort;
    }
}

